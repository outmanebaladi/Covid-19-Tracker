using Covid_19_Tracker.Entites;
using Covid_19_Tracker.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid_19_Tracker.Web.Mappers
{
	public static class EntitiesExtensions
	{
		public static CasPositifViewModel ToCasPositifViewModel(this CasPositif casPositif)
		{
			return new CasPositifViewModel
			{
				Id = casPositif.Id,
				Nom = casPositif.Nom,
				Prenom = casPositif.Prenom,
				CIN = casPositif.CIN,
				NumeroTel = casPositif.NumeroTel,
				Nombre_Contacts = casPositif.Nombre_Contacts
			};
		}

		public static CasSuiviViewModel ToCasSuiviViewModel(this CasSuivi casSuivi)
		{
			return new CasSuiviViewModel
			{
				Nom = casSuivi.Nom,
				Prenom = casSuivi.Prenom,
				CIN = casSuivi.CIN,
				NumeroTel = casSuivi.NumeroTel,
			};
		}

		public static IEnumerable<CasPositifViewModel> ToCasPositifViewModel(this List<CasPositif> casPositifs)
		{
			var models = new List<CasPositifViewModel>();
			foreach(var casPositif in casPositifs)
			{
				models.Add(casPositif.ToCasPositifViewModel());
			}
			return models;
		}

		public static IEnumerable<CasSuiviViewModel> ToCasSuiviViewModel(this List<CasSuivi> casSuivis)
		{
			var models = new List<CasSuiviViewModel>();
			foreach (var casSuivi in casSuivis)
			{
				models.Add(casSuivi.ToCasSuiviViewModel());
			}
			return models;
		}
	}
}
