using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3.DTO;
using PBL3.BLL;
using System.Net;
using PBL3.Model;
using System.IO;

namespace PBL3.View.LoginForms
{
    public partial class ForgotPasswordForm : Form
    {
        private Timer timer;
        private int count;
        private DateTime start;
        private string code;
        private Person person;
        public ForgotPasswordForm()
        {
            InitializeComponent();
            lbCode.Visible = false;
            tbCode.Visible = false;
            btnCode.Visible = false;
        }

        private void pbReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnVerify_Click(object sender, EventArgs e)
        {
            try
            {
                if (BLLPersonManagement.Instance.CheckEmail(tbEmail.Text))
                {
                    person = BLLPersonManagement.Instance.GetPersonByEmail(tbEmail.Text);

                    string fromEmail = "bookwormofficial1@gmail.com";
                    code = GenerateVerificationCode();
                    string body = GenerateEmailBody();
                    MailMessage mailMessage = new MailMessage(fromEmail, tbEmail.Text, "Verification code for resetting password", body);
                    mailMessage.IsBodyHtml = true;
                    SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
                    smtpClient.EnableSsl = true;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromEmail, "ippbaflgipgirume");
                    smtpClient.Send(mailMessage);
                    refreshTimer(sender, e);
                }
                else throw new Exception("Email doesn't exist");
            }
            catch (SmtpException) 
            { 
                CustomMessageBox.MessageBox.Show("Network failure", "Error", MessageBoxIcon.Error); 
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Error", MessageBoxIcon.Error);
            }
        }

        private void refreshTimer(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = (1 * 1000); // 1 sec
            timer.Tick += new EventHandler(timer_Tick);
            count = 0;
            start = DateTime.Now;
            btnVerify.Click -= new EventHandler(btnVerify_Click);
            btnVerify.FillColor = Color.Silver;
            btnVerify.FillColor2 = Color.Silver;
            lbCode.Visible = true;
            tbCode.Visible = true;
            btnCode.Visible = true;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            btnVerify.Text = "Send verification code (" + (60 - count) + ")";
            if (count++ >= 60 || (DateTime.Now - start).TotalSeconds > 60)
            {
                timer.Stop();
                btnVerify.Text = "Send verification code";
                btnVerify.Click += new EventHandler(btnVerify_Click);
                btnVerify.FillColor = Color.FromArgb(37, 168, 157);
                btnVerify.FillColor2 = Color.FromArgb(95, 210, 185);
            }
        }

        private void btnCode_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCode.Text == code)
                {
                    if ((DateTime.Now - start).TotalSeconds > 60 * 5)
                    {
                        CustomMessageBox.MessageBox.Show("Code expired./nPlease get another verification code", "Error", MessageBoxIcon.Error);
                        lbCode.Visible = false;
                        tbCode.Visible = false;
                        btnCode.Visible = false;
                    }
                    else
                    {
                        ResetPassword resetForm = new ResetPassword(person.Account);
                        resetForm.TopLevel = false;
                        resetForm.FormBorderStyle = FormBorderStyle.None;
                        resetForm.Dock = DockStyle.Fill;
                        pn.Controls.Add(resetForm);
                        resetForm.BringToFront();
                        resetForm.myDelegate += ResetSuccess;
                        resetForm.Show();
                    }
                }
                else if (tbCode.Text.Length != 6) throw new Exception("Invalid code length");
                else throw new Exception("Wrong code");
            }
            catch (Exception ex)
            {
                CustomMessageBox.MessageBox.Show(ex.Message, "Error", MessageBoxIcon.Error);

            }
        }

        private void ResetSuccess()
        {
            this.Close();
        }

        private string GenerateVerificationCode()
        {
            string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] stringChars = new char[6];
            Random random = new Random();
            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = chars[random.Next(chars.Length)];
            }
            string finalString = new String(stringChars);
            return finalString;
        }

        private string GenerateEmailBody()
        {
            StringBuilder mailBody = new StringBuilder();
            mailBody.AppendFormat("<h1>RESET PASSWORD VERIFICATION CODE</h1>");
            mailBody.AppendFormat("Dear {0}," ,person.PersonName);
            //mailBody.AppendFormat("<br />");
            mailBody.AppendFormat("<p>Here is your verification code for resetting your bookWorm's account password:</p>");
            //mailBody.AppendFormat("<br />");
            mailBody.AppendFormat("<big>" + code + "</big>");
            //mailBody.AppendFormat("<br />");
            mailBody.AppendFormat("<p>Best regards,</p>");
            //mailBody.AppendFormat("<br />");
            mailBody.AppendFormat("<p>bookWorm's administrator.</p>");

            return mailBody.ToString();
        }
    }
}
