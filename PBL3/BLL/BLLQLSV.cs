//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using LINQ.DTO;

//namespace LINQ.BLL
//{
//    public class BLLQLSV
//    {
//        private static BLLQLSV instance;
//        public static BLLQLSV Instance
//        {
//            get
//            {
//                if (instance == null)
//                    instance = new BLLQLSV();
//                return instance;
//            }
//            private set { }
//        }

//        private BLLQLSV()
//        {

//        }

//        public List<CBBItem> GetCBBLopSH()
//        {
//            SVEntities db = new SVEntities();
//            List<CBBItem> data = new List<CBBItem>();
//            foreach(LopSH i in db.LopSHes)
//            {
//                data.Add(new CBBItem
//                {
//                    Value = i.ID_Lop,
//                    Text = i.NameLop
//                });
//            }
//            return data;
//        }

//        public List<SV_View> GetSVViewByIDLop(int ID_Lop)
//        {
//            SVEntities db = new SVEntities();
//            List<SV_View> data = new List<SV_View>();
//            if(ID_Lop == 0)
//            {
//                foreach (SV i in db.SVs.Select(p => p))
//                {
//                    data.Add(new SV_View
//                    {
//                        MSSV = i.MSSV,
//                        NameSV = i.NameSV,
//                        NameLop = i.LopSH.NameLop
//                    });
//                }
//            }
//            else
//            {
//                foreach (SV i in db.SVs.Where(p => p.ID_Lop == ID_Lop))
//                {
//                    data.Add(new SV_View
//                    {
//                        MSSV = i.MSSV,
//                        NameSV = i.NameSV,
//                        NameLop = i.LopSH.NameLop
//                    });
//                }
//            }
//            return data;
//        }

//        public SV GetSVByMSSV(string MSSV)
//        {
//            SVEntities db = new SVEntities();
//            SV s = db.SVs.Find(MSSV);
//            return s;
//        }

//        public LopSH GetLopSHByIDLop(int ID_Lop)
//        {
//            SVEntities db = new SVEntities();
//            LopSH lop = db.LopSHes.Find(ID_Lop);
//            return lop;
//        }

//        public bool isUpdate(string MSSV)
//        {
//            SVEntities db = new SVEntities();
//            if (db.SVs.Find(MSSV) == null)
//                return false;
//            else
//                return true;
//        }

//        public void Execute(SV s)
//        {
//            SVEntities db = new SVEntities();
//            if (isUpdate(s.MSSV))
//            {
//                SV sv = db.SVs.Find(s.MSSV);
//                sv.NameSV = s.NameSV;
//                sv.ID_Lop = s.ID_Lop;
//                sv.Gender = s.Gender;
//                sv.DTB = s.DTB;
//                sv.NgaySinh = s.NgaySinh;
//                sv.Anh = s.Anh;
//                sv.HocBa = s.HocBa;
//                sv.CCNN = s.CCNN;
//            }
//            else
//            {
//                db.SVs.Add(s);
//            }
//            db.SaveChanges();
//        }

//        public void DeleteSV(List<string> ListMSSV)
//        {
//            SVEntities db = new SVEntities();
//            foreach(string i in ListMSSV)
//            {
//                SV s = db.SVs.Find(i);
//                db.SVs.Remove(s);
//                db.SaveChanges();
//            }
//        }

//        public List<SV_View> SearchSV(int ID_Lop, string searchValue)
//        {
//            List<SV_View> data = new List<SV_View> ();
//            SVEntities db = new SVEntities();
//            foreach (SV_View i in GetSVViewByIDLop(ID_Lop))
//            {
//                if(i.NameSV.Contains(searchValue) || i.MSSV.Contains(searchValue))
//                {
//                    data.Add(i);
//                }
//            }
//            return data;
//        }

//        public List<SV_View> SortSV(int ID_Lop, string sortCategory)
//        {
//            List<SV_View> data = new List<SV_View>(), list = GetSVViewByIDLop(ID_Lop);
//            if(sortCategory == "MSSV")
//                data = list.OrderBy(o => o.MSSV).ToList();
//            if (sortCategory == "NameSV")
//                data = list.OrderBy(o => o.NameSV).ToList();
//            if (sortCategory == "NameLop")
//                data = list.OrderBy(o => o.NameLop).ToList();
//            return data;
//        }
//    }
//}
