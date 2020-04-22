namespace QnSMusicStore.Logic
{
	public static partial class Factory
	{
		public static Contracts.Client.IControllerAccess<I> Create<I>() where I : Contracts.IIdentifiable
		{
			Contracts.Client.IControllerAccess<I> result = null;
			if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IAlbum))
			{
				result = new Controllers.Persistence.App.AlbumController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IArtist))
			{
				result = new Controllers.Persistence.App.ArtistController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IGenre))
			{
				result = new Controllers.Persistence.App.GenreController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.ITrack))
			{
				result = new Controllers.Persistence.App.TrackController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IRole))
			{
				result = new Controllers.Persistence.Account.RoleController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IAlbumTracks))
			{
				result = new Controllers.Business.App.AlbumTracksController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IArtistAlbums))
			{
				result = new Controllers.Business.App.ArtistAlbumsController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IAppAccess))
			{
				result = new Controllers.Business.Account.AppAccessController(CreateContext()) as Contracts.Client.IControllerAccess<I>;
			}
			return result;
		}
		public static Contracts.Client.IControllerAccess<I> Create<I>(object sharedController) where I : Contracts.IIdentifiable
		{
			Contracts.Client.IControllerAccess<I> result = null;
			if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IAlbum))
			{
				result = new Controllers.Persistence.App.AlbumController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IArtist))
			{
				result = new Controllers.Persistence.App.ArtistController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IGenre))
			{
				result = new Controllers.Persistence.App.GenreController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.ITrack))
			{
				result = new Controllers.Persistence.App.TrackController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IRole))
			{
				result = new Controllers.Persistence.Account.RoleController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IAlbumTracks))
			{
				result = new Controllers.Business.App.AlbumTracksController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IArtistAlbums))
			{
				result = new Controllers.Business.App.ArtistAlbumsController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IAppAccess))
			{
				result = new Controllers.Business.Account.AppAccessController(sharedController as Controllers.ControllerObject) as Contracts.Client.IControllerAccess<I>;
			}
			return result;
		}
		public static Contracts.Client.IControllerAccess<I> Create<I>(string sessionToken) where I : Contracts.IIdentifiable
		{
			Contracts.Client.IControllerAccess<I> result = null;
			if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IAlbum))
			{
				result = new Controllers.Persistence.App.AlbumController(CreateContext())
				{
					SessionToken = sessionToken
				}
				as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IArtist))
			{
				result = new Controllers.Persistence.App.ArtistController(CreateContext())
				{
					SessionToken = sessionToken
				}
				as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IGenre))
			{
				result = new Controllers.Persistence.App.GenreController(CreateContext())
				{
					SessionToken = sessionToken
				}
				as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.ITrack))
			{
				result = new Controllers.Persistence.App.TrackController(CreateContext())
				{
					SessionToken = sessionToken
				}
				as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IRole))
			{
				result = new Controllers.Persistence.Account.RoleController(CreateContext())
				{
					SessionToken = sessionToken
				}
				as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IAlbumTracks))
			{
				result = new Controllers.Business.App.AlbumTracksController(CreateContext())
				{
					SessionToken = sessionToken
				}
				as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IArtistAlbums))
			{
				result = new Controllers.Business.App.ArtistAlbumsController(CreateContext())
				{
					SessionToken = sessionToken
				}
				as Contracts.Client.IControllerAccess<I>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IAppAccess))
			{
				result = new Controllers.Business.Account.AppAccessController(CreateContext())
				{
					SessionToken = sessionToken
				}
				as Contracts.Client.IControllerAccess<I>;
			}
			return result;
		}
	}
}
