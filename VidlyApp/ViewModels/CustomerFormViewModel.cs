using System.Collections.Generic;
using VidlyApp.DbContext;
using VidlyApp.Models;
using VidlyApp.ViewModels;

namespace VidlyApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}