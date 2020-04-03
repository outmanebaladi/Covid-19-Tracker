using Covid_19_Tracker.Entites;
using Covid_19_Tracker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Web.Mappers
{
	public static class ViewModelsExtensions
	{
		public static CasPositif ToCasPositifEntity(this CasPositifViewModel casPositifViewModel)
		{
			return new CasPositif
			{
				Nom = casPositifViewModel.Nom,
				Prenom = casPositifViewModel.Prenom,
				Sexe = casPositifViewModel.Sexe.ToEnum<Sexe>(),
				CIN = casPositifViewModel.CIN,
				NumeroTel = casPositifViewModel.NumeroTel,
				Nombre_Contacts = casPositifViewModel.Nombre_Contacts,
				Type = casPositifViewModel.Sexe.ToEnum<TypeCasPositif>(),
			};
		}

		public static CasSuivi ToCasSuiviEntity(this CasSuiviViewModel casSuiviViewModel)
		{
			return new CasSuivi
			{
				Nom = casSuiviViewModel.Nom,
				Prenom = casSuiviViewModel.Prenom,
				Sexe = casSuiviViewModel.Sexe.ToEnum<Sexe>(),
				CIN = casSuiviViewModel.CIN,
				NumeroTel = casSuiviViewModel.NumeroTel,
			};
		}
		private static T ToEnum<T>(this string str) where T : struct
		{
			Enum.TryParse(str, out T result);
			return result;
		}
	}
}
