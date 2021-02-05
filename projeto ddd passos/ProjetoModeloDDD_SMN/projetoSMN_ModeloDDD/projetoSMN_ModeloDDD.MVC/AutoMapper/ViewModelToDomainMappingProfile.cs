using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using projetoSMN_ModeloDDD.Dominio.Entidades;
using projetoSMN_ModeloDDD.MVC.ViewModels;

namespace projetoSMN_ModeloDDD.MVC.AutoMapper
{
    public class ViewModelToDomainMappingProfile :Profile
    {
        public override string ProfileName
        {
            get { return "ViewModelToDomainMappings"; }
        }
        
        protected virtual void Configuration()
        {
            Mapper.CreateMap<UsuarioViewModel, Usuario>();
            Mapper.CreateMap<TarefaViewModel, Tarefa>();
        }


    }
}