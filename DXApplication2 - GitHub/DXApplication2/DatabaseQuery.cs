using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations.Builders;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DXApplication2;

namespace RentACarProjectRemastered
{
    class DatabaseQuery
    {
        rentAcarFinalDBEntities dbEntities = new rentAcarFinalDBEntities();

        public List<accounting> TakeAccounting()
        {
            return dbEntities.accounting.ToList();
        }

        public List<users> TakeAllUserses()
        {
            return dbEntities.users.ToList();
        }
        public List<gps> TakeGpses()
        {
            return dbEntities.gps.ToList();
        }

        public List<MeintanceExamintaion> TakeMeintanceExamintaions()
        {
            return dbEntities.MeintanceExamintaion.ToList();
        }

        public List<Rent> TakeRents()
        {
            return dbEntities.Rent.ToList();
        }

        public List<cars> TakeCarses(int groupCode)
        {
            return dbEntities.cars.ToList().Where(u=>u.carOK == 1 && u.carGroup<=groupCode).ToList();
        }

        public List<cars> TakeCarsesAll()
        {
            return dbEntities.cars.ToList();
        }

        public List<users> Login(string username,string password)
        {
            var result = dbEntities.users.Where(u => u.username == username && u.password == password).ToList();
            return result;
        }

        public List<users> takeUserId(string username)
        {
            return dbEntities.users.ToList().Where(p => p.username.Equals(username)).ToList();
        }

        public List<Rent> TakeRentsBack(int userId)
        {
            return dbEntities.Rent.ToList().Where(p => p.userId.Equals(userId)).ToList();
        }
        
        public void AddME(DateTime mTime,DateTime nMTime, DateTime eTime,DateTime nETime,int carId,float money)
        {
            //Aracın bakımıyla alakalı bilgileri yeni bir bakım nesnesine ekliyoruz.
            MeintanceExamintaion _meintanceExamintaion = new MeintanceExamintaion();
            _meintanceExamintaion.meintanceDate = mTime;
            _meintanceExamintaion.meintanceDateNext = nMTime ;
            _meintanceExamintaion.examinationsDate = eTime;
            _meintanceExamintaion.examinationsDateNext = nETime;
            _meintanceExamintaion.meCarId = carId ;
            //Yeni oluşan nesneyi database e ekliyoruz.
            dbEntities.MeintanceExamintaion.Add(_meintanceExamintaion);
            dbEntities.SaveChanges();
            //Muhasebe hesaabı için bilgileri muhasebe nesnesine ekliyoruz.
            accounting _accounting = new accounting();
            _accounting.accountType = 2; // accountType = 2 Gider demektir.
            _accounting.accountMeId = dbEntities.MeintanceExamintaion.ToList().Count;
            _accounting.accountMoney = money;
            _accounting.accountDate = DateTime.Now;
            //Yeni oluşan nesneyi database e ekliyoruz.
            dbEntities.accounting.Add(_accounting);
            dbEntities.SaveChanges();
            //Uyarı mesajı veriyoruz.
            MessageBox.Show("Bakım ve Muayenesi Eklemesi yapıldı!");
        }

        public void UpdateMeintance(DateTime mTime, DateTime nMTime, DateTime eTime, DateTime nETime, int carId,
            float money)
        {
            //Aracın bakımıyla alakalı bilgileri yeni bir bakım nesnesine ekliyoruz.
            MeintanceExamintaion _meintanceExamintaion = new MeintanceExamintaion();
            _meintanceExamintaion.meintanceDate = mTime;
            _meintanceExamintaion.meintanceDateNext = nMTime;
            _meintanceExamintaion.examinationsDate = eTime;
            _meintanceExamintaion.examinationsDateNext = nETime;
            _meintanceExamintaion.meCarId = carId;
            //Yeni oluşan nesneyi database e ekliyoruz.
            dbEntities.MeintanceExamintaion.Add(_meintanceExamintaion);
            dbEntities.SaveChanges();
            //Muhasebe hesaabı için bilgileri muhasebe nesnesine ekliyoruz.
            accounting _accounting = new accounting();
            _accounting.accountType = 2; // accountType = 2 Gider demektir.
            _accounting.accountMeId = dbEntities.MeintanceExamintaion.ToList().Count;
            _accounting.accountMoney = money;
            _accounting.accountDate = DateTime.Now;
            //Yeni oluşan nesneyi database e ekliyoruz.
            dbEntities.accounting.Add(_accounting);
            dbEntities.SaveChanges();
            //Uyarı mesajı veriyoruz.
            //MessageBox.Show("Bakım ve Muayenesi Eklemesi yapıldı!");
        }

        public void DeleteMeintance(int meID)
        {
            MeintanceExamintaion _meintanceExamintaion = new MeintanceExamintaion();
            _meintanceExamintaion.meId = meID;
            var entity = dbEntities.Entry(_meintanceExamintaion);
            entity.State = EntityState.Deleted;
            dbEntities.SaveChanges();
        }

        public void AddCars(int carGroup,int carKm,string carModel,string carManufacturer,int carCare,int carExamination,float carPrice, float money)
        {
            //Araçla ilgili bilgileri alıp, yeni oluşturduğumuz araç nesnesine ekliyoruz.
            cars _cars = new cars();
            _cars.carGroup = carGroup;
            _cars.carCare = carCare;
            _cars.carExamination = carExamination;
            _cars.carKm = carKm;
            _cars.carManufacturer = carManufacturer;
            _cars.carModel = carModel;
            _cars.carPrice = carPrice;
            //Araç nesnesini database eklemesini yapıyoruz.
            dbEntities.cars.Add(_cars);
            dbEntities.SaveChanges();
            //Aracın maaliyetini muhasebe hesabı için gerekli bilgileri alıp database e ekliyoruz.
            accounting _accounting = new accounting();
            _accounting.accountType = 2; // accountType = 2 Gider demektir.
            _accounting.accountMeId = dbEntities.cars.ToList().Count;
            _accounting.accountMoney = money;
            _accounting.accountDate = DateTime.Now;
            //Database eklemesi - muhasebe
            dbEntities.accounting.Add(_accounting);
            dbEntities.SaveChanges();
            //Uyarı Mesajı veriyoruz.
            MessageBox.Show("Araç Eklendi!");
        }

        public void UpdateCars(int carId,int carGroup, int carKm, string carModel, string carManufacturer, int carCare, int carExamination, float carPrice)
        {
            //Araçla ilgili bilgileri alıp, yeni oluşturduğumuz araç nesnesine ekliyoruz.
            cars _cars = new cars();
            _cars.carId = carId;
            _cars.carGroup = carGroup;
            _cars.carCare = carCare;
            _cars.carExamination = carExamination;
            _cars.carKm = carKm;
            _cars.carManufacturer = carManufacturer;
            _cars.carModel = carModel;
            _cars.carPrice = carPrice;
            //Araç nesnesini database güncellenmesini yapıyoruz.
            var entity = dbEntities.Entry(_cars);
            entity.State = EntityState.Modified;
            dbEntities.SaveChanges();
            //Uyarı Mesajı veriyoruz.
            MessageBox.Show("Araç Eklendi!");
        }

        public void RentCarsUpdate(int carId)
        {
            cars _cars = new cars();
            _cars.carId = carId;
            _cars.carOK = 0;

            var entity = dbEntities.Entry(_cars);
            entity.State = EntityState.Modified;
            dbEntities.SaveChanges();
        }

        public void DeleteCars(int carId)
        {
            //Araçla ilgili bilgileri alıp, yeni oluşturduğumuz araç nesnesine ekliyoruz.
            cars _cars = new cars();
            _cars.carId = carId;
            var entity = dbEntities.Entry(_cars);
            entity.State = EntityState.Deleted;
            dbEntities.SaveChanges();
            //Uyarı Mesajı veriyoruz.
            MessageBox.Show("Araç Eklendi!");
        }

        public void AddRent(DateTime rentDate,DateTime rentFinishDate,int carId,int userId,float money)
        {
            //Kiralanan aracın bilgilerini alır
            Rent _rent = new Rent();
            _rent.rentDate = rentDate;
            _rent.RentFinishDate = rentFinishDate;
            _rent.carId = carId;
            _rent.userId = userId;
            //Bilgileri database e aktarır.
            dbEntities.Rent.Add(_rent);
            dbEntities.SaveChanges();
            //Muhasabe bilgilerini alır.
            accounting _accounting = new accounting();
            _accounting.accountDate = DateTime.Now;
            _accounting.accountMoney = money;
            _accounting.accountUserid = userId;
            _accounting.accountRentid = dbEntities.Rent.ToList().Count;
            _accounting.accountType = 1; // accountType = 1 Gelir demektir.
            //Bilgileri database e aktarır.
            dbEntities.accounting.Add(_accounting);
            dbEntities.SaveChanges();
        }

        public void AddUser(string username, string password,string NameSurname, DateTime userBirth, string LicenseId, DateTime LicenseYear, string userTC,string userAdress)
        {
            users _users = new users();
            _users.username = username;
            _users.password = password;
            _users.userNameSurname = NameSurname;
            _users.userAge = userBirth;
            _users.licenseId = LicenseId;
            _users.licenseYear = LicenseYear;
            _users.userTc = userTC;
            _users.userAdress = userAdress;
            _users.userScore = 100;
            _users.usermembership = 4;
            _users.userAccountCreated = DateTime.Now;
            _users.usergroup = 2;
            _users.userMonthlyRent = 0;
            dbEntities.users.Add(_users);
        }

        public void UpdateUser(int userId,string username, string password, string NameSurname, DateTime userBirth, string LicenseId, DateTime LicenseYear, string userTC, string userAdress)
        {
            users _users = new users();
            _users.userId = userId;
            _users.username = username;
            _users.password = password;
            _users.userNameSurname = NameSurname;
            _users.userAge = userBirth;
            _users.licenseId = LicenseId;
            _users.licenseYear = LicenseYear;
            _users.userTc = userTC;
            _users.userAdress = userAdress;
            _users.userScore = 100;
            _users.usermembership = 4;
            _users.userAccountCreated = DateTime.Now;
            _users.usergroup = 2;
            _users.userMonthlyRent = 0;

            var entity = dbEntities.Entry(_users);
            entity.State = EntityState.Modified;
            dbEntities.SaveChanges();
        }

        public void DeleteUser(int userId)
        {
            users _users = new users();
            _users.userId = userId;

            var entity = dbEntities.Entry(_users);
            entity.State = EntityState.Deleted;
            dbEntities.SaveChanges();
        }

        public void RandomGPSForLoop(int gpsCarId)
        {
            for (int i = 0; i < 20; i++)
            {
                float gpsXcord, gpsYcord;
                float min = (float)1.00000;
                float max = (float)180.0000;
                Random GPS = new Random();
                gpsXcord = (float)(GPS.NextDouble() * (max - min) + min);
                Random GPS2 = new Random();
                gpsYcord = (float)(GPS2.NextDouble() * (max - min) + min);

                gps _gps = new gps();
                _gps.gpsCarId = gpsCarId;
                _gps.gpsXcord = gpsXcord;
                _gps.gpsYcord = gpsYcord;
                dbEntities.gps.Add(_gps);
                dbEntities.SaveChanges();
            }
        }

        public void AddPayments(int accountUserId,float money,int accountType)
        {
            accounting _accounting = new accounting();
            _accounting.accountType = accountType;
            _accounting.accountUserid = accountUserId;
            _accounting.accountMoney = money;

            dbEntities.accounting.Add(_accounting);
            dbEntities.SaveChanges();
        }

        public void DeletePayments(int accountId)
        {
            accounting _accounting = new accounting();
            _accounting.accountId= accountId;

            var entity = dbEntities.Entry(_accounting);
            entity.State = EntityState.Deleted;
            dbEntities.SaveChanges();
        }

        public void UpdatePayments(int accountId,int userId, int paymentType, float money)
        {
            accounting _accounting = new accounting();
            _accounting.accountId = accountId;
            _accounting.accountMoney = money;
            _accounting.accountUserid = userId;
            _accounting.accountType = paymentType;

            var entity = dbEntities.Entry(_accounting);
            entity.State = EntityState.Modified;
            dbEntities.SaveChanges();
        }

        public List<accounting> UserPayments(int userId)
        {
            return dbEntities.accounting.ToList().Where(p => p.accountId.Equals(userId)).ToList();
        }

    }
}
