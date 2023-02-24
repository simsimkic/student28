using Model.UserModel;
using System;
using Klinika.Repository;
using System.Linq;
using System.Collections.Generic;

namespace Repository.UserRepository
{
    public class DirectorRepository : IDirectorRepository
    {
        private static DirectorRepository instance { get; set; }
        private FileRepository<Director> stream { get; set; }

        public static DirectorRepository GetInstance(FileRepository<Director> stream)
        {
            if(instance == null)
            {
                instance = new DirectorRepository(stream);
            }
            return instance;
        }

        private DirectorRepository(FileRepository<Director> stream)
        {
            this.stream = stream;
        }

        public Director RegisterDirector(Director director)
        {
            var allDirectors = stream.GetAll().ToList();
            allDirectors.Add(director);
            stream.SaveAll(allDirectors);
            return director;
        }
        public Director EditDirector(Director editedDirector)
        {
            var allDirectors = stream.GetAll().ToList();
            foreach(Director director in allDirectors)
            {
                EditDirectorIfFound(director, editedDirector);
            }
            stream.SaveAll(allDirectors);
            return editedDirector;
        }

        public List<Director> getAllDirectors()
        {
            return stream.GetAll().ToList();
        }

        private void EditAllAtributes(Director director, Director editedDirector)
        {
            director.adress = editedDirector.adress;
            director.appGraded = editedDirector.appGraded;
            director.dateOfBirth = editedDirector.dateOfBirth;
            director.email = editedDirector.email;
            director.employeeId = editedDirector.employeeId;
            director.feedback = editedDirector.feedback;
            director.gender = editedDirector.gender;
            director.martialStatus = editedDirector.martialStatus;
            director.name = editedDirector.name;
            director.password = editedDirector.password;
            director.personalId = editedDirector.personalId;
            director.phoneNumber = editedDirector.phoneNumber;
            director.room = editedDirector.room;
            director.surname = editedDirector.surname;
            director.userLogged = editedDirector.userLogged;
            director.username = editedDirector.username;
        }

        private void EditDirectorIfFound(Director director, Director editedDirector)
        {
            if (director.employeeId == editedDirector.employeeId)
            {
                EditAllAtributes(director, editedDirector);
            }
        }
    }
}