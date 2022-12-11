
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using static DentalClinic.Areas.Admin.Constants.AdminConstants;

namespace DentalClinic.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRolleName)]
    public class AdminBaseController : Controller
    {
    }
}
