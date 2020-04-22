namespace QnSMusicStore.Logic.Controllers.Business.App
{
	sealed partial class AlbumTracksController : GenericRelationController<QnSMusicStore.Contracts.Business.App.IAlbumTracks, Entities.Business.App.AlbumTracks, QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Logic.Entities.Persistence.App.Album, QnSMusicStore.Contracts.Persistence.App.ITrack, QnSMusicStore.Logic.Entities.Persistence.App.Track>
	{
		static AlbumTracksController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public AlbumTracksController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public AlbumTracksController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
		protected override GenericController<QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Logic.Entities.Persistence.App.Album> CreateMasterController(ControllerObject controller)
		{
			return new QnSMusicStore.Logic.Controllers.Persistence.App.AlbumController(controller);
		}
		protected override GenericController<QnSMusicStore.Contracts.Persistence.App.ITrack, QnSMusicStore.Logic.Entities.Persistence.App.Track> CreateDetailController(ControllerObject controller)
		{
			return new QnSMusicStore.Logic.Controllers.Persistence.App.TrackController(controller);
		}
	}
}
namespace QnSMusicStore.Logic.Controllers.Business.App
{
	sealed partial class ArtistAlbumsController : GenericRelationController<QnSMusicStore.Contracts.Business.App.IArtistAlbums, Entities.Business.App.ArtistAlbums, QnSMusicStore.Contracts.Persistence.App.IArtist, QnSMusicStore.Logic.Entities.Persistence.App.Artist, QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Logic.Entities.Persistence.App.Album>
	{
		static ArtistAlbumsController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public ArtistAlbumsController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public ArtistAlbumsController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
		protected override GenericController<QnSMusicStore.Contracts.Persistence.App.IArtist, QnSMusicStore.Logic.Entities.Persistence.App.Artist> CreateMasterController(ControllerObject controller)
		{
			return new QnSMusicStore.Logic.Controllers.Persistence.App.ArtistController(controller);
		}
		protected override GenericController<QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Logic.Entities.Persistence.App.Album> CreateDetailController(ControllerObject controller)
		{
			return new QnSMusicStore.Logic.Controllers.Persistence.App.AlbumController(controller);
		}
	}
}
namespace QnSMusicStore.Logic.Controllers.Business.Account
{
	[Logic.Modules.Security.Authorize("SysAdmin")]
	sealed partial class AppAccessController : BusinessControllerAdapter<QnSMusicStore.Contracts.Business.Account.IAppAccess, Entities.Business.Account.AppAccess>
	{
		static AppAccessController()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public AppAccessController(DataContext.IContext context):base(context)
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public AppAccessController(ControllerObject controller):base(controller)
		{
			Constructing();
			Constructed();
		}
	}
}
