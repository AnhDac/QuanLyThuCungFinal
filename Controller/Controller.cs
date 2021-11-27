using QuanLyThuCung.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace QuanLyThuCung.Database
{
    class Controller
    {
        ThuCungEntities db;

        public Controller()
        {
            db = new ThuCungEntities();
        }

        /*=============Get An Object=================*/

        public dynamic getUserCheckLogin(string username, string password)
        {
            var result = db.Users.Where(p => p.Username == username && p.PassWord == password).Select(c => new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission }).ToList().SingleOrDefault();
            return result;
        }

        /*=============Get value=================*/
        public string getPermissUser(int id)
        {
            string permiss = "";
            var result = db.Users.Where(p => p.ID == id).Select(c => new { IDUser = c.ID, Ten = c.Name, Username = c.Username, Password = c.PassWord, Permission = c.Permission }).ToList().SingleOrDefault();
            if (result != null)
                permiss = result.Permission.ToString().Trim();
            return permiss;
        }

        public string getProfiContractSellTheoThangVaNam(int month, int year)
        {
            var total = new System.Data.Entity.Core.Objects.ObjectParameter("total", 0);
            db.usp_GetProfitContractSellTheoThangVaNam(month, year, total);
            return total.Value + "";
        }

        public string getTotalMoneyTransactionContractSellTheoThangVaNam(int month, int year)
        {
            var total = new System.Data.Entity.Core.Objects.ObjectParameter("total", 0);
            db.usp_GetTotalMoneyTransactionContractSellTheoThangVaNam(month, year, total);
            return total.Value + "";
        }

        public string getTotalMoneyTransactionContractSerTheoThangVaNam(int month, int year)
        {
            var total = new System.Data.Entity.Core.Objects.ObjectParameter("total", 0);
            db.usp_GetTotalMoneyTransactionContractSerTheoThangVaNam(month, year, total);
            return total.Value + "";
        }



        //=====Lay Danh Sach Thu Cung theo Tim Kiem
        public List<Pet> LayDanhSachThuCungTheoTimKiem(string loaitimkiem, string giatritimkiem)
        {
            List<Pet> Pets = new List<Pet>();
            switch (loaitimkiem)
            {
                case "Loại":
                    Pets = LayDanhSachThuCungChuaBanTheoTenLoai(giatritimkiem);
                    break;

                case "Giới Tính":
                    Pets = LayDanhSachThuCungChuaBanTheoGioiTinh(giatritimkiem);
                    break;
                case "Tuổi":
                    Pets = LayDanhSachThuCungChuaBanTheoTuoi(giatritimkiem);
                    break;
                default:
                    Pets = LayDanhSachThuCungChuaBan();
                    break;
            }
            return Pets;
        }


        private List<Pet> LayDanhSachThuCungChuaBanTheoTuoi(string giatritimkiem)
        {
            List<Pet> Pets = new List<Pet>();
            int age = Convert.ToInt32(giatritimkiem);
            var lstPet = db.usp_GetThuCungChuaBanTheoTuoi(age).ToList();
            for (int i = 0; i < lstPet.Count(); i++)
            {
                Pet pet = new Pet();
                pet.ID_Pet = lstPet.ElementAt(i).ID;
                pet.ID_Spec = lstPet.ElementAt(i).IDLoại;
                pet.ID_Sup = lstPet.ElementAt(i).NCC;
                pet.PriceImport = lstPet.ElementAt(i).Giá_Nhập;
                pet.Sex = lstPet.ElementAt(i).Giới_Tính;
                pet.Age = lstPet.ElementAt(i).Tuổi;
                pet.Weight = lstPet.ElementAt(i).Cân_Nặng;
                Pets.Add(pet);
            }
            return Pets;
        }

        public List<Pet> LayDanhSachThuCungChuaBanTheoGioiTinh(string giatritimkiem)
        {
            List<Pet> Pets = new List<Pet>();
            var lstPet = db.usp_GetThuCungChuaBanTheoGioiTinh(giatritimkiem).ToList();
            for (int i = 0; i < lstPet.Count(); i++)
            {
                Pet pet = new Pet();
                pet.ID_Pet = lstPet.ElementAt(i).ID;
                pet.ID_Spec = lstPet.ElementAt(i).IDLoại;
                pet.ID_Sup = lstPet.ElementAt(i).NCC;
                pet.PriceImport = lstPet.ElementAt(i).Giá_Nhập;
                pet.Sex = lstPet.ElementAt(i).Giới_Tính;
                pet.Age = lstPet.ElementAt(i).Tuổi;
                pet.Weight = lstPet.ElementAt(i).Cân_Nặng;
                Pets.Add(pet);
            }
            return Pets;
        }

        public List<Pet> LayDanhSachThuCungChuaBanTheoTenLoai(string giatritimkiem)
        {
            List<Pet> Pets = new List<Pet>();
            var lstPet = db.usp_GetThuCungChuaBanTheoLoai(giatritimkiem).ToList();
            for (int i = 0; i < lstPet.Count(); i++)
            {
                Pet pet = new Pet();
                pet.ID_Pet = lstPet.ElementAt(i).ID;
                pet.ID_Spec = lstPet.ElementAt(i).IDLoại;
                pet.ID_Sup = lstPet.ElementAt(i).NCC;
                pet.PriceImport = lstPet.ElementAt(i).Giá_Nhập;
                pet.Sex = lstPet.ElementAt(i).Giới_Tính;
                pet.Age = lstPet.ElementAt(i).Tuổi;
                pet.Weight = lstPet.ElementAt(i).Cân_Nặng;
                Pets.Add(pet);
            }
            return Pets;
        }

        public List<Pet> LayDanhSachThuCungChuaBan()
        {
            List<Pet> Pets = new List<Pet>();
            var lstPet = db.usp_GetThuCungChuaBan().ToList();

            for (int i = 0; i < lstPet.Count(); i++)
            {
                Pet pet = new Pet();
                pet.ID_Pet = lstPet.ElementAt(i).ID_Pet;
                pet.ID_Spec = lstPet.ElementAt(i).ID_Spec;
                pet.ID_Sup = lstPet.ElementAt(i).ID_Sup;
                pet.PriceImport = lstPet.ElementAt(i).PriceImport;
                pet.Sex = lstPet.ElementAt(i).Sex;
                pet.Age = lstPet.ElementAt(i).Age;
                pet.Weight = lstPet.ElementAt(i).Weight;
                Pets.Add(pet);
            }
            return Pets;
        }

    }

}
