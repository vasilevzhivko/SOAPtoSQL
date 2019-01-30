using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace SOAPConnectToDatabase
{
    public class DatabaseOperations : IOperateDatabase
    {
        public List<Doctor> GetAllDoctors()
        {
            List<Doctor> allDocs = new List<Doctor>();
            using (var context = new VetSystemEntities())
            {
                try
                {
                    allDocs.AddRange(context.Doctors);
                }
                catch (EntityException ex)
                {
                    //log exception
                }
            }
            return allDocs;
        }

        public async Task<List<Doctor>> GetAllDoctorsAsync()
        {
            List<Doctor> allDocs = new List<Doctor>();
            using (var context = new VetSystemEntities())
            {
                 var docs = await context.Doctors.ToListAsync();
                 allDocs.AddRange(docs);
            }
            return allDocs;
        }

        public void InsertDoctor(Doctor d)
        {
            using (var context = new VetSystemEntities())
            {
                context.Doctors.Add(d);
                context.SaveChanges();
            }
        }

        public async Task InsertDoctorAsync(Doctor d)
        {
            using (var context = new VetSystemEntities())
            {
                context.Doctors.Add(d);
                await context.SaveChangesAsync();
            }
        }
    }
}
