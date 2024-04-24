using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckPoint.NHibernate
{
    public class User
    {

        public virtual int UserId { get; set; }
        public virtual int Code { get; set; }
        public virtual string Name { get; set; }
        public virtual string FirstSurName { get; set; }
        public virtual string SecondSurName { get; set; }
        public virtual string Email { get; set; }
        public virtual string EmailPassword { get; set; }
        public virtual string EmailSmtpServer { get; set; }
        public virtual int UserAccessLevelId { get; set; }
        public virtual bool HasTimeInProgress { get; set; }
        public virtual string FingerPrintOne { get; set; }
        public virtual string FingerPrintTwo { get; set; }
        public virtual string FingerPrintOneBitmap { get; set; }
        public virtual string FingerPrintTwoBitmap { get; set; }
        public virtual int LimitOvertimePerYear { get; set; }
        public virtual bool Active { get; set; }
        public virtual float CostIn { get; set; }
        public virtual float CostOut { get; set;}
        public virtual string PCName { get; set; }
    }
}
