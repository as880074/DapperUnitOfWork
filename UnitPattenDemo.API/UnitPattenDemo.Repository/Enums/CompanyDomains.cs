using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace UnitPattenDemo.Repository.Enums
{
    public enum CompanyDomains
    {
        [Display(Name = "GIIPH")] GIIPH = 1,
        [Obsolete, Display(Name = "OSS")] OSS = 2,
        [Obsolete, Display(Name = "VPO")] VPO = 3,
        [Display(Name = "OGG")] OGG = 4,
    }
}
