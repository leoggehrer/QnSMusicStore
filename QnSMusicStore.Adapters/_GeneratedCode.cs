namespace QnSMusicStore.Adapters
{
	public static partial class Factory
	{
		public static Contracts.Client.IAdapterAccess<I> Create<I>()
		{
			Contracts.Client.IAdapterAccess<I> result = null;
			if (Adapter == AdapterType.Controller)
			{
				if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IAlbum))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.App.IAlbum>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IArtist))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.App.IArtist>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IGenre))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.App.IGenre>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.ITrack))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.App.ITrack>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IRole))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.Account.IRole>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IUser))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.Account.IUser>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IAlbumTracks))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Business.App.IAlbumTracks>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IArtistAlbums))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Business.App.IArtistAlbums>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IAppAccess))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Business.Account.IAppAccess>() as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IIdentityUser))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Business.Account.IIdentityUser>() as Contracts.Client.IAdapterAccess<I>;
				}
			}
			else if (Adapter == AdapterType.Service)
			{
				if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IAlbum))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.App.IAlbum, Transfer.Persistence.App.Album>(BaseUri, "Album") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IArtist))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.App.IArtist, Transfer.Persistence.App.Artist>(BaseUri, "Artist") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IGenre))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.App.IGenre, Transfer.Persistence.App.Genre>(BaseUri, "Genre") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.ITrack))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.App.ITrack, Transfer.Persistence.App.Track>(BaseUri, "Track") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IRole))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.Account.IRole, Transfer.Persistence.Account.Role>(BaseUri, "Role") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IUser))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.Account.IUser, Transfer.Persistence.Account.User>(BaseUri, "User") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IAlbumTracks))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Business.App.IAlbumTracks, Transfer.Business.App.AlbumTracks>(BaseUri, "AlbumTracks") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IArtistAlbums))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Business.App.IArtistAlbums, Transfer.Business.App.ArtistAlbums>(BaseUri, "ArtistAlbums") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IAppAccess))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Business.Account.IAppAccess, Transfer.Business.Account.AppAccess>(BaseUri, "AppAccess") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IIdentityUser))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Business.Account.IIdentityUser, Transfer.Business.Account.IdentityUser>(BaseUri, "IdentityUser") as Contracts.Client.IAdapterAccess<I>;
				}
			}
			return result;
		}
		public static Contracts.Client.IAdapterAccess<I> Create<I>(string sessionToken)
		{
			Contracts.Client.IAdapterAccess<I> result = null;
			if (Adapter == AdapterType.Controller)
			{
				if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IAlbum))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.App.IAlbum>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IArtist))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.App.IArtist>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IGenre))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.App.IGenre>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.ITrack))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.App.ITrack>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IRole))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.Account.IRole>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IUser))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Persistence.Account.IUser>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IAlbumTracks))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Business.App.IAlbumTracks>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IArtistAlbums))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Business.App.IArtistAlbums>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IAppAccess))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Business.Account.IAppAccess>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IIdentityUser))
				{
					result = new Controller.GenericControllerAdapter<QnSMusicStore.Contracts.Business.Account.IIdentityUser>(sessionToken) as Contracts.Client.IAdapterAccess<I>;
				}
			}
			else if (Adapter == AdapterType.Service)
			{
				if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IAlbum))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.App.IAlbum, Transfer.Persistence.App.Album>(sessionToken, BaseUri, "Album") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IArtist))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.App.IArtist, Transfer.Persistence.App.Artist>(sessionToken, BaseUri, "Artist") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IGenre))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.App.IGenre, Transfer.Persistence.App.Genre>(sessionToken, BaseUri, "Genre") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.ITrack))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.App.ITrack, Transfer.Persistence.App.Track>(sessionToken, BaseUri, "Track") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IRole))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.Account.IRole, Transfer.Persistence.Account.Role>(sessionToken, BaseUri, "Role") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IUser))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Persistence.Account.IUser, Transfer.Persistence.Account.User>(sessionToken, BaseUri, "User") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IAlbumTracks))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Business.App.IAlbumTracks, Transfer.Business.App.AlbumTracks>(sessionToken, BaseUri, "AlbumTracks") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.App.IArtistAlbums))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Business.App.IArtistAlbums, Transfer.Business.App.ArtistAlbums>(sessionToken, BaseUri, "ArtistAlbums") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IAppAccess))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Business.Account.IAppAccess, Transfer.Business.Account.AppAccess>(sessionToken, BaseUri, "AppAccess") as Contracts.Client.IAdapterAccess<I>;
				}
				else if (typeof(I) == typeof(QnSMusicStore.Contracts.Business.Account.IIdentityUser))
				{
					result = new Service.GenericServiceAdapter<QnSMusicStore.Contracts.Business.Account.IIdentityUser, Transfer.Business.Account.IdentityUser>(sessionToken, BaseUri, "IdentityUser") as Contracts.Client.IAdapterAccess<I>;
				}
			}
			return result;
		}
	}
}
