using Microsoft.AspNetCore.Mvc;
using Application.Models;
namespace Application.Controllers;
[ApiController]
[Route("api/userapplication")]
public class UserController:ControllerBase
{
    private readonly EmpolyeeContext DB;
    public UserController(EmpolyeeContext db) 
    {
        this.DB=db;
    }
   
    [HttpPost("Insertapplication")]
    public object Insertapplication( User usobj)

    {
        string message="";
        try
        {
            ApplicationEmp euse=new ApplicationEmp();
            if(euse.EmployeeCode==0)
            {
                euse.EmployeeCode=usobj.empEmployeeCode;
                euse.EmployeeName=usobj.empEmployeeName;
                euse.Ctc=usobj.empCtc;
                euse.Basic=usobj.empBasic;
                euse.HraType=usobj.empHraType;
                euse.Hra=usobj.empHra;
                euse.Pf=usobj.empPf;
                euse.Lta=usobj.empLta;
                euse.Fual=usobj.empFual;
                euse.Special=usobj.empSpecial;
                
            DB.ApplicationEmps.Add(euse);   
            
            int result=this.DB.SaveChanges();
            if(result>0)
            {
            message="user added sucessfully";

        }
        else{
            message="failed";

        }
        return Ok(message);
        DB.SaveChanges();
        return new Response{status="sucessfully",message="employee added!"};
            }}
            catch(System.Exception)
            {
                throw;
            }
return new Response{status="error",message="invalid information"};
            
            }

[HttpGet("GetUserDetails")]
    public IActionResult GetByID(int uid)
    {
            var users =this.DB.ApplicationEmps.FirstOrDefault(o=>o.EmployeeCode==uid);
            return Ok(users);
    }
    [HttpGet("GetAlluser")]
    public IQueryable<ApplicationEmp> GetAlluser()
    {
        try
        {
            return DB.ApplicationEmps;

        }
        catch(System.Exception)
        {
            throw;
        }
}
[HttpDelete("DeleteUserDetails/{uid}")]
    public IActionResult DeleteUser(int uid)
    {
        string message = "";
            var user = this.DB.ApplicationEmps.Find(uid);
            if (user == null)
            {
                return NotFound();
            }

            this.DB.ApplicationEmps.Remove(user);
            int result = this.DB.SaveChanges();
            if (result > 0)
            {
                message = " UserData deleled sucessfully ";
            }
            else
            {
                message = "failed";
            }

            return Ok(message);
        }

}

    
    

    
              