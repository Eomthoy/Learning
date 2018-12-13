using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NetCoreApp.Models;

namespace NetCoreApp.Repository
{
    public class AutoMapperFile : Profile
    {
        public AutoMapperFile()
        {
            CreateMap<SysMenu, SysMenuDto>().ForMember(det => det.Children, option => option.Ignore()).ForMember(det => det.BtnChildren, option => option.Ignore());
            CreateMap<SysMenuDto, SysMenu>();
            CreateMap<SysButton, SysButtonDto>();
            CreateMap<SysButtonDto, SysButton>();
        }
    }
}
