using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduBlog.Core.Domain.Helper
{
    public enum EStatus
    {
        Draft = 1,
        Cancel = 2,
        WaitingForApproval = 3,
        Reject = 4,
        WaitingForPublish = 5,
        Publish = 6
    }
}
