using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace projetoSMN_ModeloDDD.MVC.AutoMapper
{
	public class AutoMapperConfig
	{
        public static void RegisterMappings()
        {
            // nesse metodo faz os registro do mapeamento

            Mapper.Initialize(x =>
            {
                x.AddProfile<DomainToViewModelMappingProfile>();
                x.AddProfile<ViewModelToDomainMappingProfile>();

            });
        }

	}
}