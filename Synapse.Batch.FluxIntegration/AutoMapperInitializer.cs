using AutoMapper;
using Synapse.Application.Models;
using Synapse.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Synapse.Batch.FluxIntegration
{
    public static class AutoMapperInitializer
    {
        public static void Initialize()
        {
            Mapper.Initialize(config =>
            {
                config.CreateMap<CsvRecordLigne, AdsCommun>().IncludeAllDerived();
                config.CreateMap<CsvRecordLigne, CreAds>()
                    .ForMember(dest => dest.TYPE_GR_RSQ, opt => opt.MapFrom(src => src.Col26))
                    .ForMember(dest => dest.TYPE_RSQ, opt => opt.MapFrom(src => src.Col27))
                    .ForMember(dest => dest.NAT_PREST, opt => opt.MapFrom(src => src.Col28))
                    .ForMember(dest => dest.MNT, opt => opt.MapFrom(src => src.Col29));

                config.CreateMap<CsvRecordLigne, SsaAds>()
                    .ForMember(dest => dest.SEG_SSA, opt => opt.MapFrom(src => src.Col26))
                    .ForMember(dest => dest.TYPE_GR_RSQ, opt => opt.MapFrom(src => src.Col27))
                    .ForMember(dest => dest.TYPE_RSQ, opt => opt.MapFrom(src => src.Col28))
                    .ForMember(dest => dest.NAT_PREST, opt => opt.MapFrom(src => src.Col29));
            });
        }
    }
}
