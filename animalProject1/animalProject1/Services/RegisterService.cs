//using animalProject1.Services.Interfaces;
using Sabio.Data;
using animalProject1.Domain;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using animalProject1.Models.Requests;

namespace animalProject1.Services
{
    public class RegisterService : BaseService  //, IRegistriesService
    {

        //// Dependency injected GetAll,
        //// interface required for loose coupling of dependencies.
        //public User Mapper(IDataReader reader)
        //{
        //    User p = new User();
        //    int startingIndex = 0; //startingOrdinal
        //    p = new User();
        //    p.Id = reader.GetSafeInt32(startingIndex++);
        //    p.Name = reader.GetSafeString(startingIndex++);
        //    p.Email = reader.GetSafeString(startingIndex++);
        //    p.Subject = reader.GetSafeString(startingIndex++);
        //    p.Message = reader.GetSafeString(startingIndex++);
        //    p.DateAdded = reader.GetSafeDateTime(startingIndex++);
        //    p.DateModified = reader.GetSafeDateTime(startingIndex++);
        //    p.UserId = reader.GetSafeString(startingIndex++);
        //    return p;
        //}
        //public List<User> GetAll()
        //{
        //    List<User> list = null;
        //    DataProvider.ExecuteCmd(GetConnection, "dbo.Register_GetAll"
        //       , inputParamMapper: null
        //       , map: delegate (IDataReader reader, short set) //function from BaseService
        //       {
        //           User p = Mapper(reader);
        //           if (list == null)
        //           {
        //               list = new List<User>();
        //           }
        //           list.Add(p);
        //       });
        //    return list;
        //}

        public static List<Register> GetAll()
        {
            List<Register> list = null;
            DataProvider.ExecuteCmd(GetConnection, "dbo.Register_GetAll"
               , inputParamMapper: null
               , map: delegate (IDataReader reader, short set) //function from BaseService
               {
                   Register p = new Register();
                   int startingIndex = 0; //startingOrdinal
                   p = new Register();
                   p.Id = reader.GetSafeInt32(startingIndex++);
                   p.Name = reader.GetSafeString(startingIndex++);
                   p.Email = reader.GetSafeString(startingIndex++);
                   p.Subject = reader.GetSafeString(startingIndex++);
                   p.Message = reader.GetSafeString(startingIndex++);
                   p.DateAdded = reader.GetSafeDateTime(startingIndex++);
                   p.DateModified = reader.GetSafeDateTime(startingIndex++);
                   p.UserId = reader.GetSafeString(startingIndex++);
                   if (list == null)
                   {
                       list = new List<Register>();
                   }
                   list.Add(p);
               });
            return list;
        }

        public static int Post(AddRegisterRequest model)
        {
            int OutputId = 0;
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.Register_Insert"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {
                   paramCollection.AddWithValue("@Name", model.Name);
                   paramCollection.AddWithValue("@Email", model.Email);
                   paramCollection.AddWithValue("@Subject", model.Subject);
                   paramCollection.AddWithValue("@Message", model.Message);
                   paramCollection.AddWithValue("@UserId", model.UserId);
                   SqlParameter p = new SqlParameter("@Id", System.Data.SqlDbType.Int);
                   p.Direction = System.Data.ParameterDirection.Output;
                   paramCollection.Add(p);
               }, returnParameters: delegate (SqlParameterCollection param)
               {
                   int.TryParse(param["@Id"].Value.ToString(), out OutputId);
               }
               );
            return OutputId;
        }

        public static Register GetById(string id)
        {
            Register p = null;
            DataProvider.ExecuteCmd(GetConnection, "dbo.Register_GetById"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {
                   paramCollection.AddWithValue("@Id", id);
               }, map: delegate (IDataReader reader, short set)
               {
                   int startingIndex = 0; //startingOrdinal
                   p = new Register();
                   p.Id = reader.GetSafeInt32(startingIndex++);
                   p.Name = reader.GetSafeString(startingIndex++);
                   p.Email = reader.GetSafeString(startingIndex++);
                   p.Subject = reader.GetSafeString(startingIndex++);
                   p.Message = reader.GetSafeString(startingIndex++);
                   p.DateAdded = reader.GetSafeDateTime(startingIndex++);
                   p.DateModified = reader.GetSafeDateTime(startingIndex++);
                   p.UserId = reader.GetSafeString(startingIndex++);
               });
            return p;
        }

       
        public static void Update(UpdateRegisterRequest model)
        {
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.Register_Update"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {
                   paramCollection.AddWithValue("@Id", model.Id);
                   paramCollection.AddWithValue("@Name", model.Name);
                   paramCollection.AddWithValue("@Email", model.Email);
                   paramCollection.AddWithValue("@Subject", model.Subject);
                   paramCollection.AddWithValue("@Message", model.Message);
                   paramCollection.AddWithValue("@UserId", model.UserId);
               }
               );
        }

        public static void Delete(int Id)
        {
            DataProvider.ExecuteNonQuery(GetConnection, "dbo.Register_Delete"
               , inputParamMapper: delegate (SqlParameterCollection paramCollection)
               {
                   paramCollection.AddWithValue("@Id", Id);
               }

               );
        }






    }
}