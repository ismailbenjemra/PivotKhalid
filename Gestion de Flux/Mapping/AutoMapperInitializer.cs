using AutoMapper;
using Gestion_de_Flux.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gestion_de_Flux.Mapping
{
    public static class AutoMapperInitializer
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<CsvRecordLigne, AdsCommun>().IncludeAllDerived();
                config.CreateMap<CsvRecordLigne, Cre>()
                    .ForMember(dest => dest.TYPE_GR_RSQ, opt => opt.MapFrom(src => src.Col26))
                    .ForMember(dest => dest.TYPE_RSQ, opt => opt.MapFrom(src => src.Col27))
                    .ForMember(dest => dest.NAT_PREST, opt => opt.MapFrom(src => src.Col28))
                    .ForMember(dest => dest.MNT, opt => opt.MapFrom(src => src.Col29));

                config.CreateMap<CsvRecordLigne, Ssa>()
                    .ForMember(dest => dest.SEG_SSA, opt => opt.MapFrom(src => src.Col26))
                    .ForMember(dest => dest.TYPE_GR_RSQ, opt => opt.MapFrom(src => src.Col27))
                    .ForMember(dest => dest.TYPE_RSQ, opt => opt.MapFrom(src => src.Col28))
                    .ForMember(dest => dest.NAT_PREST, opt => opt.MapFrom(src => src.Col29));
            });
        }
    }
}
