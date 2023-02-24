using Controller.DrugController;
using Controller.ExaminationController;
using Controller.RoomController;
using Controller.UserController;
using Controller.WorkTimeController;
using Klinika.Repository;
using Model.DrugModel;
using Model.ExaminationModel;
using Model.RoomModel;
using Model.UserModel;
using Model.WorkTimeModel;
using Repository.DrugRepository;
using Repository.ExaminationRepository;
using Repository.RoomRepository;
using Repository.UserRepository;
using Repository.WorkTimeRepository;
using Service.DrugService;
using Service.ExaminationService;
using Service.RoomService;
using Service.UserService;
using Service.WorkTimeService;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Klinika
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    
    public partial class App : Application
    {
        private const string DRUG_PATH = "../../Repository/Data/drugs.json";
        private const string DIAGNOSIS_PATH = "../../Repository/Data/diagnoses.json";
        private const string EXAMINATION_PATH = "../../Repository/Data/examinations.json";
        private const string HOSPITALIZATION_PATH = "../../Repository/Data/hospitalizations.json";
        private const string PRESCRIPTION_PATH = "../../Repository/Data/prescriptions.json";
        private const string SYMPTOM_PATH = "../../Repository/Data/symptoms.json";
        private const string THERAPY_PATH = "../../Repository/Data/therapies.json";
        private const string EQUIPMENT_PATH = "../../Repository/Data/equipments.json";
        private const string RENOVATION_PATH = "../../Repository/Data/renovations.json";
        private const string ROOM_PATH = "../../Repository/Data/rooms.json";
        private const string ARTICLE_PATH = "../../Repository/Data/articles.json";
        private const string DEPARTMENT_PATH = "../../Repository/Data/departments.json";
        private const string DIRECTOR_PATH = "../../Repository/Data/directors.json";
        private const string DOCTOR_PATH = "../../Repository/Data/doctors.json";
        private const string FEEDBACK_PATH = "../../Repository/Data/feedbacks.json";
        private const string GUEST_USER_MEDICAL_RECORD_PATH = "../../Repository/Data/guestUserMedicalRecords.json";
        private const string GUEST_USER_PATH = "../../Repository/Data/guestUsers.json";
        private const string HOSPITAL_GRADE_PATH = "../../Repository/Data/hospitalGrades.json";
        private const string MEDICAL_RECORD_PATH = "../../Repository/Data/medicalRecords.json";
        private const string ON_DUTY_PATH = "../../Repository/Data/onDutys.json";
        private const string PATIENT_PATH = "../../Repository/Data/patients.json";
        private const string SECRETARY_PATH = "../../Repository/Data/secretaries.json";
        private const string APPOINTMENT_PATH = "../../Repository/Data/appointments.json";
        private const string WORK_TIME_PATH = "../../Repository/Data/workTimes.json";

        public App()
        {
            FileRepository<Drug> streamDrug = new FileRepository<Drug>(DRUG_PATH);
            var drugRepository = DrugRepository.GetInstance(streamDrug);
            var drugService = DrugService.GetInstance(drugRepository);
            var drugController = DrugController.GetInstance(drugService);

            FileRepository<Diagnosis> streamDiagnosis = new FileRepository<Diagnosis>(DIAGNOSIS_PATH);
            var diagnosisRepository = DiagnosisRepository.GetInstance(streamDiagnosis);
            var diagnosisService = DiagnosisService.GetInstance(diagnosisRepository);
            var diagnosisController = DiagnosisController.GetInstance(diagnosisService);

            FileRepository<Examination> streamExamination = new FileRepository<Examination>(EXAMINATION_PATH);
            var examinationRepository = ExaminationRepository.GetInstance(streamExamination);
            var examinationService = ExaminationService.GetInstance(examinationRepository);
            var examinationController = ExaminationController.GetInstance(examinationService);

            FileRepository<Hospitalization> streamHospitalization = new FileRepository<Hospitalization>(HOSPITALIZATION_PATH);
            var hospitalizationRepository = HospitalizationRepository.GetInstance(streamHospitalization);
            var hospitalizationService = HospitalizationService.GetInstance(hospitalizationRepository);
            var hospitalizationController = HospitalizationController.GetInstance(hospitalizationService);

            FileRepository<Prescription> streamPrescription = new FileRepository<Prescription>(PRESCRIPTION_PATH);
            var prescriptionRepository = PrescriptionRepository.GetInstance(streamPrescription);
            var prescriptionService = PrescriptionService.GetInstance(prescriptionRepository);
            var prescriptionController = PrescriptionController.GetInstance(prescriptionService);

            FileRepository<Symptom> streamSymptom = new FileRepository<Symptom>(SYMPTOM_PATH);
            var symptomRepository = SymptomRepository.GetInstance(streamSymptom);
            var symptomService = SymptomService.GetInstance(symptomRepository);
            var symptomController = SymptomController.GetInstance(symptomService);

            FileRepository<Therapy> streamTherapy = new FileRepository<Therapy>(THERAPY_PATH);
            var therapyRepository = TherapyRepository.GetInstance(streamTherapy);
            var therapyService = TherapyService.GetInstance(therapyRepository);
            var therapyController = TherapyController.GetInstance(therapyService);

            FileRepository<Equipment> streamEquipment = new FileRepository<Equipment>(EQUIPMENT_PATH);
            var equipmentRepository = EquipmentRepository.GetInstance(streamEquipment);
            var equipmentService = EquipmentService.GetInstance(equipmentRepository);
            var equipmentController = EquipmentController.GetInstance(equipmentService);

            FileRepository<Renovation> streamRenovation = new FileRepository<Renovation>(RENOVATION_PATH);
            var renovationRepository = RenovationRepository.GetInstance(streamRenovation);
            var renovationService = RenovationService.GetInstance(renovationRepository);
            var renovationController = RenovationController.GetInstance(renovationService);

            FileRepository<Room> streamRoom = new FileRepository<Room>(ROOM_PATH);
            var roomRepository = RoomRepository.GetInstance(streamRoom);
            var roomService = RoomService.GetInstance(roomRepository);
            var roomController = RoomController.GetInstance(roomService);

            FileRepository<Article> streamArticle = new FileRepository<Article>(ARTICLE_PATH);
            var articleRepository = ArticleRepository.GetInstance(streamArticle);
            var articleService = ArticleService.GetInstance(articleRepository);
            var articleController = ArticleController.GetInstance(articleService);

            FileRepository<Department> streamDepartment = new FileRepository<Department>(DEPARTMENT_PATH);
            var departmentRepository = DepartmentRepository.GetInstance(streamDepartment);
            var departmentService = DepartmentService.GetInstance(departmentRepository);
            var departmentController = DepartmentController.GetInstance(departmentService);

            FileRepository<Director> streamDirector = new FileRepository<Director>(DIRECTOR_PATH);
            var directorRepository = DirectorRepository.GetInstance(streamDirector);
            var directorService = DirectorService.GetInstance(directorRepository);
            var directorController = DirectorController.GetInstance(directorService);

            FileRepository<Doctor> streamDoctor = new FileRepository<Doctor>(DOCTOR_PATH);
            var doctorRepository = DoctorRepository.GetInstance(streamDoctor);
            var doctorService = DoctorService.GetInstance(doctorRepository, departmentService);
            var doctorController = DoctorController.GetInstance(doctorService);

            FileRepository<Feedback> streamFeedback = new FileRepository<Feedback>(FEEDBACK_PATH);
            var feedbackRepository = FeedbackRepository.GetInstance(streamFeedback);
            var feedbackService = FeedbackService.GetInstance(feedbackRepository);
            var feedbackController = FeedBackController.GetInstance(feedbackService);

            FileRepository<GuestUserMedicalRecord> streamGuestUserMedicalRecord = new FileRepository<GuestUserMedicalRecord>(GUEST_USER_MEDICAL_RECORD_PATH);
            var guestUserMedicalRecordRepository = GuestUserMedicalRecordRepository.GetInstance(streamGuestUserMedicalRecord);
            var guestUserMedicalRecordService = GuestUserMedicalRecordService.GetInstance(guestUserMedicalRecordRepository);
            var guestUserMedicalRecordController = GuestUserMedicalRecordController.GetInstance(guestUserMedicalRecordService);

            FileRepository<GuestUser> streamGuestUser = new FileRepository<GuestUser>(GUEST_USER_PATH);
            var guestUserRepository = GuestUserRepository.GetInstance(streamGuestUser);
            var guestUserService = GuestUserService.GetInstance(guestUserRepository);
            var guestUserController = GuestUserController.GetInstance(guestUserService);

            FileRepository<HospitalGrade> streamHospitalGrade = new FileRepository<HospitalGrade>(HOSPITAL_GRADE_PATH);
            var hospitalGradeRepository = HospitalGradeRepository.GetInstance(streamHospitalGrade);
            var hospitalGradeService = HospitalGradeService.GetInstance(hospitalGradeRepository);
            var hospitalGradeController = HospitalGradeController.GetInstance(hospitalGradeService);

            FileRepository<MedicalRecord> streamMedicalRecord = new FileRepository<MedicalRecord>(MEDICAL_RECORD_PATH);
            var medicalRecordRepository = MedicalRecordRepository.GetInstance(streamMedicalRecord);
            var medicalRecordService = MedicalRecordService.GetInstance(medicalRecordRepository);
            var medicalRecordController = MedicalRecordController.GetInstance(medicalRecordService);

            FileRepository<OnDuty> streamOnDuty = new FileRepository<OnDuty>(ON_DUTY_PATH);
            var onDutyRepository = OnDutyRepository.GetInstance(streamOnDuty);
            var onDutyService = OnDutyService.GetInstance(onDutyRepository);
            var onDutyController = OnDutyController.GetInstance(onDutyService);

            FileRepository<Patient> streamPatient = new FileRepository<Patient>(PATIENT_PATH);
            var patientRepository = PatientRepository.GetInstance(streamPatient);
            var patientService = PatientService.GetInstance(patientRepository);
            var patientController = PatientController.GetInstance(patientService);

            FileRepository<Secretary> streamSecretary = new FileRepository<Secretary>(SECRETARY_PATH);
            var secretaryRepository = SecretaryRepository.GetInstance(streamSecretary);
            var secretaryService = SecretaryService.GetInstance(secretaryRepository);
            var secretaryController = SecretaryController.GetInstance(secretaryService);

            FileRepository<WorkTime> streamWorkTime = new FileRepository<WorkTime>(WORK_TIME_PATH);
            var workTimeRepository = WorkTimeRepository.GetInstance(streamWorkTime);
            var workTimeService = WorkTimeService.GetInstance(workTimeRepository);
            var workTimeController = WorkTimeController.GetInstance(workTimeService);

            FileRepository<Appointment> streamAppointment = new FileRepository<Appointment>(APPOINTMENT_PATH);
            var appointmentRepository = AppointmentRepository.GetInstance(streamAppointment);
            var appointmentService = AppointmentService.GetInstance(appointmentRepository, workTimeService);
            var appointmentController = AppointmentController.GetInstance(appointmentService);
            
            /*
            Ingredient ingredient1 = new Ingredient("paracetamol 500mg");
            Ingredient ingredient2 = new Ingredient("doksiciklin 500mg");
            Ingredient ingredient3 = new Ingredient("askorbinska kiselina 500mg");
            Ingredient ingredient4 = new Ingredient("paracetamol 1000mg");
            Ingredient ingredient5 = new Ingredient("bromazepam 6mg");
            Ingredient ingredient6 = new Ingredient("bactrim 500mg");
            Ingredient ingredient7 = new Ingredient("penicilin 500mg");
            Ingredient ingredient8 = new Ingredient("amoksiciklin 1000mg");
            List<Ingredient> ingredients1 = new List<Ingredient>();
            List<Ingredient> ingredients2 = new List<Ingredient>();
            List<Ingredient> ingredients3 = new List<Ingredient>();
            ingredients1.Add(ingredient1);
            ingredients1.Add(ingredient2);
            ingredients1.Add(ingredient3);
            ingredients2.Add(ingredient4);
            ingredients2.Add(ingredient5);
            ingredients3.Add(ingredient6);
            ingredients3.Add(ingredient7);
            ingredients3.Add(ingredient8);

            Allergens allergen1 = new Allergens("DOKSICIKLINI");
            Allergens allergen2 = new Allergens("PARACETAMOLI");
            Allergens allergen3 = new Allergens("BENDOZODIAZEPINI");
            Allergens allergen4 = new Allergens("BACTRIM");
            Allergens allergen5 = new Allergens("LAKTOZA");
            List<Allergens> allergens1 = new List<Allergens>();
            List<Allergens> allergens2 = new List<Allergens>();
            List<Allergens> allergens3 = new List<Allergens>();
            allergens1.Add(allergen1);
            allergens1.Add(allergen2);
            allergens2.Add(allergen3);
            allergens3.Add(allergen4);
            allergens3.Add(allergen5);

            Drug drug1 = new Drug(ingredients1, null, allergens1, 12843, "Palitrex", 40, true);
            Drug drug2 = new Drug(ingredients2, new AlternativeDrug(drug1), allergens2, 99239, "Palitrex", 15, false);
            Drug drug3 = new Drug(ingredients3, new AlternativeDrug(drug2), allergens3, 18482, "Palitrex", 60, true);
            drugController.Add(drug1);
            drugController.Add(drug2);
            drugController.Add(drug3);
            Console.WriteLine(drugController.GetDrugById(99239).ingredients[1].ingredientName);
            Console.WriteLine(drugController.GetDrugById(99239).alternativeDrug.drug.drugId);
            Console.WriteLine(drugController.GetDrugById(99239).allergens.ToString());
            Console.WriteLine(drugController.GetDrugById(99239).drugId);
            Console.WriteLine(drugController.GetDrugById(99239).name);
            Console.WriteLine(drugController.GetDrugById(99239).amount);
            Console.WriteLine(drugController.GetDrugById(99239).approved.ToString());
            
            
            Symptom symptom1 = new Symptom("kasalj");
            Symptom symptom2 = new Symptom("temperatura");
            Symptom symptom3 = new Symptom("glavobolja");
            Symptom symptom4 = new Symptom("dijareja");
            Symptom symptom5 = new Symptom("nadutost");
            Symptom symptom6 = new Symptom("pritisak");
            Symptom symptom7 = new Symptom("povracanje");
            Symptom symptom8 = new Symptom("svrab");
            Symptom symptom9 = new Symptom("dezorijentisanost");
            Symptom symptom10 = new Symptom("malaksalost");
            symptomController.AddSymptom(symptom1);
            symptomController.AddSymptom(symptom2);
            symptomController.AddSymptom(symptom3);
            symptomController.AddSymptom(symptom4);
            symptomController.AddSymptom(symptom5);
            symptomController.AddSymptom(symptom6);
            symptomController.AddSymptom(symptom7);
            symptomController.AddSymptom(symptom8);
            symptomController.AddSymptom(symptom9);
            symptomController.AddSymptom(symptom10);

            List<Symptom> symptoms1 = new List<Symptom>();
            List<Symptom> symptoms2 = new List<Symptom>();
            List<Symptom> symptoms3 = new List<Symptom>();
            symptoms1.Add(symptom1);
            symptoms1.Add(symptom2);
            symptoms1.Add(symptom3);
            symptoms1.Add(symptom4);
            symptoms2.Add(symptom5);
            symptoms2.Add(symptom6);
            symptoms3.Add(symptom7);
            symptoms3.Add(symptom8);
            symptoms3.Add(symptom9);
            symptoms3.Add(symptom10);
            Diagnosis diagnosis1 = new Diagnosis(symptoms1, "COVID-19(Korona-virus)");
            Diagnosis diagnosis2 = new Diagnosis(symptoms2, "Mononukleoza");
            Diagnosis diagnosis3 = new Diagnosis(symptoms3, "Dijabetes tip 2");
            diagnosisController.Add(diagnosis1);
            diagnosisController.Add(diagnosis2);
            diagnosisController.Add(diagnosis3);
            
            //DateTime.Parse("19/06/2020 00:00:00");
            
            String date1S = "01-07-2020 08:30";
            String date2S = "01-07-2020 09:00";
            String date3S = "01-07-2020 09:00";
            String date4S = "01-07-2020 09:30";
            String date5S = "01-07-2020 10:00";
            String date6S = "01-07-2020 10:30";
            String date7S = "01-07-2020 11:00";
            String date8S = "01-07-2020 12:00";
            String date9S = "01-07-2020 12:30";
            var date1 = DateTime.ParseExact(date1S, "dd-MM-yyyy HH:mm", null);
            var date2 = DateTime.ParseExact(date2S, "dd-MM-yyyy HH:mm", null);
            var date3 = DateTime.ParseExact(date3S, "dd-MM-yyyy HH:mm", null);
            var date4 = DateTime.ParseExact(date4S, "dd-MM-yyyy HH:mm", null);
            var date5 = DateTime.ParseExact(date5S, "dd-MM-yyyy HH:mm", null);
            var date6 = DateTime.ParseExact(date6S, "dd-MM-yyyy HH:mm", null);
            var date7 = DateTime.ParseExact(date7S, "dd-MM-yyyy HH:mm", null);
            var date8 = DateTime.ParseExact(date8S, "dd-MM-yyyy HH:mm", null);
            var date9 = DateTime.ParseExact(date9S, "dd-MM-yyyy HH:mm", null);

            List<Appointment> appps = new List<Appointment>();
            appps.Add(new Appointment(new Date(date1,date1 ,date2),true,1));
            appointmentController.Add(new Appointment(new Date(date1, date1, date2), true, 1));
            appps.Add(new Appointment(new Date(date1, date2, date3), true, 2));
            appointmentController.Add(new Appointment(new Date(date1, date2, date3), true, 2));
            appps.Add(new Appointment(new Date(date1, date3, date4), true, 3));
            appointmentController.Add(new Appointment(new Date(date1, date3, date4), true, 3));
            appps.Add(new Appointment(new Date(date1, date4, date5), true, 4));
            appointmentController.Add(new Appointment(new Date(date1, date4, date5), true, 4));
            appps.Add(new Appointment(new Date(date1, date5, date6), true, 5));
            appointmentController.Add(new Appointment(new Date(date1, date5, date6), true, 5));
            appps.Add(new Appointment(new Date(date1, date6, date7), true, 6));
            appointmentController.Add(new Appointment(new Date(date1, date6, date7), true, 6));
            appps.Add(new Appointment(new Date(date1, date7, date8), true, 7));
            appointmentController.Add(new Appointment(new Date(date1, date7, date8), true, 7));
            appps.Add(new Appointment(new Date(date1, date8, date9), true, 8));
            appointmentController.Add(new Appointment(new Date(date1, date8, date9), true, 8));
            WorkTime w1 = new WorkTime(1235, null, appps, date1, date9, date1, date9, true);
            workTimeController.AddWorkTime(w1);


            String date1Sb = "02-06-2020 12:30";
            String date2Sb= "02-06-2020 13:00";
            String date3Sb= "02-06-2020 13:30";
            String date4Sb= "02-06-2020 14:00";
            String date5Sb= "02-06-2020 14:30";
            String date6Sb= "02-06-2020 15:00";
            String date7Sb= "02-06-2020 15:30";
            String date8Sb= "02-06-2020 16:00";
            String date9Sb= "02-06-2020 16:30";
            var date1b = DateTime.ParseExact(date1Sb, "dd-MM-yyyy HH:mm", null);
            var date2b = DateTime.ParseExact(date2Sb, "dd-MM-yyyy HH:mm", null);
            var date3b = DateTime.ParseExact(date3Sb, "dd-MM-yyyy HH:mm", null);
            var date4b = DateTime.ParseExact(date4Sb, "dd-MM-yyyy HH:mm", null);
            var date5b = DateTime.ParseExact(date5Sb, "dd-MM-yyyy HH:mm", null);
            var date6b = DateTime.ParseExact(date6Sb, "dd-MM-yyyy HH:mm", null);
            var date7b = DateTime.ParseExact(date7Sb, "dd-MM-yyyy HH:mm", null);
            var date8b = DateTime.ParseExact(date8Sb, "dd-MM-yyyy HH:mm", null);
            var date9b = DateTime.ParseExact(date9Sb, "dd-MM-yyyy HH:mm", null);

            List<Appointment> apppsb = new List<Appointment>();
            apppsb.Add(new Appointment(new Date(date1b, date1b, date2b), true, 9));
            appointmentController.Add(new Appointment(new Date(date1b, date1b, date2b), true, 9));
            apppsb.Add(new Appointment(new Date(date1b, date2b, date3b), true, 10));
            appointmentController.Add(new Appointment(new Date(date1b, date2b, date3b), true, 10));
            apppsb.Add(new Appointment(new Date(date1b, date3b, date4b), true, 11));
            appointmentController.Add(new Appointment(new Date(date1b, date3b, date4b), true, 11));
            apppsb.Add(new Appointment(new Date(date1b, date4b, date5b), true, 12));
            appointmentController.Add(new Appointment(new Date(date1b, date4b, date5b), true, 12));
            apppsb.Add(new Appointment(new Date(date1b, date5b, date6b), true, 13));
            appointmentController.Add(new Appointment(new Date(date1b, date5b, date6b), true, 13));
            apppsb.Add(new Appointment(new Date(date1b, date6b, date7b), true, 14));
            appointmentController.Add(new Appointment(new Date(date1b, date6b, date7b), true, 14));
            apppsb.Add(new Appointment(new Date(date1b, date7b, date8b), true, 15));
            appointmentController.Add(new Appointment(new Date(date1b, date7b, date8b), true, 15));
            apppsb.Add(new Appointment(new Date(date1b, date8b, date9b), true, 16));
            appointmentController.Add(new Appointment(new Date(date1b, date8b, date9b), true, 16));



            WorkTime w2 = new WorkTime(1236, null, apppsb, date1b, date9b, date1b, date9b, true);
            workTimeController.AddWorkTime(w2);


            Equipment equipment1 = new Equipment(1, "stolica", 100, 60);
            equipmentController.AddEquipment(equipment1);
            Equipment equipment2 = new Equipment(2, "zavoj", 60, 35);
            equipmentController.AddEquipment(equipment2);
            Equipment equipment3 = new Equipment(3, "stetoskop", 80, 45);
            equipmentController.AddEquipment(equipment3);
            List<Equipment> equipments = new List<Equipment>();
            equipments.Add(equipment1);
            equipments.Add(equipment2);
            equipments.Add(equipment3);
            RoomEquipment roomEquipment1 = new RoomEquipment(10, equipment1);
            RoomEquipment roomEquipment2 = new RoomEquipment(20, equipment2);
            RoomEquipment roomEquipment3 = new RoomEquipment(30, equipment3);
            List<RoomEquipment> roomEquipments = new List<RoomEquipment>();
            roomEquipments.Add(roomEquipment1);
            roomEquipments.Add(roomEquipment2);
            roomEquipments.Add(roomEquipment3);
            Room room1= new Room(roomEquipments, w2, 1, RoomType.ExaminationRoom, true, 30, 20, 10);
            Room room2 = new Room(roomEquipments, w1, 1, RoomType.HospitalBedroom, true, 30, 20, 10);
            Room room3 = new Room(roomEquipments, w2, 1, RoomType.Office, true, 30, 20, 10);
            Room room4 = new Room(roomEquipments, null, 1, RoomType.SurgeryRoom, true, 30, 20, 10);
            w1.room = room3;
            workTimeController.EditWorkTime(w1);
            w2.room = room4;
            workTimeController.EditWorkTime(w2);

            Renovation renovation1 = new Renovation(room1, date1, date5);
            Renovation renovation2 = new Renovation(room2, date3, date9);
            renovationRepository.AddRenovation(renovation1);
            renovationRepository.AddRenovation(renovation2);
            Article article1 = new Article(null, "Zdrav zivot", "Ako zelis da budes zdrav moras da trcis puno i da jedes zdravu hranu i da pijes puno vode a ne da sedis ceo dan i nista ne radis jer ces umreti od infarkta.", date2);
            Article article2 = new Article(null, "Prevencija dijabetesa", "Nemojte jesti puno slatkisa i budite fizicki aktivni kako ne biste dobili dijabetes.", date3);

            DoctorGrade doctorGrade1 = new DoctorGrade(5);
            DoctorGrade doctorGrade2 = new DoctorGrade(4);
            DoctorGrade doctorGrade3 = new DoctorGrade(3);
            DoctorGrade doctorGrade4 = new DoctorGrade(5);
            List<DoctorGrade> grades = new List<DoctorGrade>();
            grades.Add(doctorGrade1);
            grades.Add(doctorGrade2);
            grades.Add(doctorGrade3);
            grades.Add(doctorGrade4);
            DaysOff daysOff1 = new DaysOff(20);
            OnDuty onDuty1 = new OnDuty(null, date1, date2, date1, date2);
            Country country1 = new Country("Srbija");
            City city1 = new City(country1,"Novi Sad",21000);
            Adress adress1 = new Adress(city1, "Narodnog Fronta", 11);
            List<WorkTime> worktimes1 = new List<WorkTime>();
            worktimes1.Add(w1);
            worktimes1.Add(w2);
            Doctor doctor1 = new Doctor(worktimes1, grades, daysOff1, onDuty1, "Kardioloija", true, 1, adress1, null, "Denis", "Fruza", 1234, DateTime.Parse("10-07-1998"),Gender.Male, MartialStatus.Divorced,"denis","denis","denisfruza98@hotmail.com",21662654,false,false);
            doctorController.RegisterDoctor(doctor1);

            DoctorGrade doctorGrade1b = new DoctorGrade(5);
            DoctorGrade doctorGrade2b = new DoctorGrade(4);
            DoctorGrade doctorGrade3b = new DoctorGrade(3);
            DoctorGrade doctorGrade4b = new DoctorGrade(5);
            List<DoctorGrade> gradesb = new List<DoctorGrade>();
            gradesb.Add(doctorGrade1);
            gradesb.Add(doctorGrade2);
            gradesb.Add(doctorGrade3);
            gradesb.Add(doctorGrade4);
            DaysOff daysOff1b = new DaysOff(20);
            OnDuty onDuty1b = new OnDuty(null, date1, date2, date1, date2);
            Country country1b = new Country("Srbija");
            City city1b = new City(country1, "Zrenjanin", 23000);
            Adress adress1b = new Adress(city1, "Mileticeva", 22);
            List<WorkTime> worktimes1b = new List<WorkTime>();
            worktimes1b.Add(w1);
            worktimes1b.Add(w2);
            Doctor doctor1b = new Doctor(worktimes1b, gradesb, daysOff1b, onDuty1b, "Hirurgija", true, 1, adress1b, null, "Petar", "Petrovic", 4444, DateTime.Parse("10-07-1998"), Gender.Male, MartialStatus.Widow, "petar", "petar", "petarpetrovic@hotmail.com", 21662654, false, false);
            doctorController.RegisterDoctor(doctor1b);
            List<Doctor> doctors = new List<Doctor>();
            List<Doctor> doctorsb = new List<Doctor>();
            doctors.Add(doctor1);
            doctorsb.Add(doctor1b);
            Department department = new Department(doctors, "Kardiologija");
            Department departmentb = new Department(doctorsb, "Hirurgija");
            departmentController.Add(department);
            departmentController.Add(departmentb);

            
            List<Examination> examinations = new List<Examination>();
            MedicalRecord medicalrecord = new MedicalRecord(examinations, "A+", 180.00, 100.00, "PENICILIN", 12345);
            Patient patient = new Patient(medicalrecord,null,null, adress1, null, "Danilo", "Paripovic", 1234, DateTime.Parse("10-10-1998"), Gender.Male, MartialStatus.Widow, "danilo", "danilo", "parip@gmail.com", 51345, false, false);
            medicalRecordController.Add(medicalrecord);
            patientController.RegisterPatient(patient);
            
            List<Examination> examinationsb = new List<Examination>();
            MedicalRecord medicalrecordb = new MedicalRecord(examinationsb, "B+", 180.00, 100.00, "NEMA", 15315);
            Patient patientb = new Patient(medicalrecordb,null,null, adress1, null, "Stefan", "Stefanovic", 1234, DateTime.Parse("10-10-1998"), Gender.Male, MartialStatus.Widow, "stefan", "stefan", "parip@gmail.com", 51345, false, false);
            medicalRecordController.Add(medicalrecordb);
            patientController.RegisterPatient(patientb);
           // Examination examinationb = new Examination(diagnosis1, null, w1.appointment[0], null, doctor1, patientb, 1234, ExaminationType.Regular, false, null, false);
            //medicalrecordb.examination.Add(examinationb);
            //medicalRecordController.Edit(medicalrecordb);

            Secretary secretary = new Secretary(daysOff1, worktimes1, 1235, adress1, null, "Strahinja", "Cvijanovic", 1234, DateTime.Parse("03-06-1998"), Gender.Male, MartialStatus.Divorced, "strahinja", "strahinja", "strahinja@gmail.com", 12342, false, false);
            secretaryController.RegisterSecretary(secretary);
            Director director = new Director(room1, 1234, adress1, null, "Dimitrije", "Bulaja", 1234, DateTime.Parse("11-11-1998"), Gender.Male, MartialStatus.Divorced, "dimitrije", "dimitrije", "dimitrije@gmail.com", 12432, false, false);
            directorRepository.RegisterDirector(director);
            

            // Doctor doctor = new Doctor(null, null, null, null, null, 0, null, null, "GGGG", "GGG", 0, DateTime.Parse("10.07.1998"), 0, 0, null, null, null, 0, true, true);

            /*
            Equipment equipment = new Equipment(1, "gaza", 10, 10);
            equipmentController.AddEquipment(equipment);

            foreach(Equipment eq in equipmentRepository.GetAllEquipment())
            {
                Console.WriteLine(eq.ToString());
            }
            List<Doctor> specijalisti = new List<Doctor>();
            //specijalisti.Add(doctor1);
            Department department = new Department(specijalisti, "Kardiologija");
            //specijalisti.Add(doctor);
            */
        }
    }
}
