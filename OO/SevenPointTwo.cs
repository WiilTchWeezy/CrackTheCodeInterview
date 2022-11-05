using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview.OO
{
    public enum Rank
    {
        Responder,
        Manager,
        Director
    }
    public abstract class Employee
    {
        public string Name { get; set; }
        public Rank Rank { get; set; }
        public bool IsFree { get { return CurrentCall == null; } }
        public Call CurrentCall { get; set; }
    }

    public class Responder : Employee
    {
        public Responder()
        {
            this.Rank = Rank.Responder;
        }
    }

    public class Manager : Employee
    {
        public Manager()
        {
            this.Rank = Rank.Manager;
        }
    }

    public class Director : Employee
    {
        public Director()
        {
            this.Rank = Rank.Director;
        }
    }

    public class Call
    {
        public Rank Rank { get; set; }
        public string Caller { get; set; }
        public Employee Handler { get; set; }

        public Call(string caller)
        {
            Caller = caller;
            Rank = Rank.Responder;
        }

        public Call(string caller, Rank rank)
        {
            Caller = caller;
            Rank = rank;
        }
    }

    public class CallHandler
    {
        private List<Employee> _employees;

        public CallHandler()
        {
            _employees = new List<Employee>();
        }

        public void AddEmployees(Employee employee)
        {
            _employees.Add(employee);
        }

        public void DispatchCall(string caller)
        {
            var call = new Call(caller);
            DispatchCall(call);
        }

        public void DispatchCall(Call call)
        {
            var employee = _employees.Where(x => x.Rank == call.Rank && x.IsFree).FirstOrDefault();
            if (employee == null)
            {
                if (call.Rank == Rank.Director)
                    throw new ArgumentNullException();
                else
                    ScalateCall(call);
            }
            else
            {
                AnswerCall(call, employee);
            }
        }

        private void AnswerCall(Call call, Employee employee)
        {
            employee.CurrentCall = call;
            call.Handler = employee;
        }

        private void ScalateCall(Call call)
        {
            if (call.Rank == Rank.Director)
                return;
            call.Rank++;
            DispatchCall(call);
        }
    }
}
