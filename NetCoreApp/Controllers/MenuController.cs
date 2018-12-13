using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreApp.Models;
using NetCoreApp.Repository;

namespace NetCoreApp.Controllers
{
    [Produces("application/json")]
    [Route("api/Menu")]
    public class MenuController : Controller
    {
        [Route("Menu/GetMenu")]
        [HttpGet]
        public List<SysMenuDto> GetMenu()
        {
            List<SysMenuDto> result = new List<SysMenuDto>();
            using (NetCoreContext db = new NetCoreContext())
            {
                //一级菜单
                List<SysMenu> lev1Menus = db.SysMenu.Where(x => x.MenuParentNo == null).ToList();
                result = AutoMapper.Mapper.Map<List<SysMenuDto>>(lev1Menus);
                foreach (SysMenuDto lev1Menu in result)
                {
                    //一级按钮
                    lev1Menu.BtnChildren = AutoMapper.Mapper.Map<List<SysButtonDto>>(db.SysButton.Where(x => x.MenuId == lev1Menu.Id).ToList());
                    //二级菜单
                }
            }

            return result;
        }
    }
}