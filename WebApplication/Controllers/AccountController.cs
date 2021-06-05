using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.SqlClient;
using WebApplication.Models;
namespace WebApplication.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(Account account)
        {
            string connectionString = @"Data Source=DESKTOP-4DOQ385\SQLEXPRESS;Initial Catalog=DbTest;Integrated Security=True ";
            using (SqlConnection con=new SqlConnection(connectionString))
            {
                con.Open();
                string query = "insert into contact values(@Name,@Phone,@Email,@Text)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Name", account.Name);
                cmd.Parameters.AddWithValue("@Phone", account.Phone);
                cmd.Parameters.AddWithValue("@Email", account.Email);
                cmd.Parameters.AddWithValue("@Text", account.Text);
                cmd.ExecuteNonQuery();
            }
             return View("Create");
        }


    }
}