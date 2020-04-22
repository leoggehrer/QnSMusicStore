namespace QnSMusicStore.Transfer.Business.App
{
	using System.Text.Json.Serialization;
	public partial class AlbumTracks : QnSMusicStore.Contracts.Business.App.IAlbumTracks
	{
		static AlbumTracks()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public AlbumTracks()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public void CopyProperties(QnSMusicStore.Contracts.Business.App.IAlbumTracks other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				Master.CopyProperties(other.Master);
				ClearDetails();
				foreach (var detail in other.Details)
				{
					AddDetail(detail);
				}
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSMusicStore.Contracts.Business.App.IAlbumTracks other, ref bool handled);
		partial void AfterCopyProperties(QnSMusicStore.Contracts.Business.App.IAlbumTracks other);
	}
}
namespace QnSMusicStore.Transfer.Business.App
{
	partial class AlbumTracks : RelationModel<QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Transfer.Persistence.App.Album, QnSMusicStore.Contracts.Persistence.App.ITrack, QnSMusicStore.Transfer.Persistence.App.Track>
	{
	}
}
namespace QnSMusicStore.Transfer.Business.App
{
	using System.Text.Json.Serialization;
	public partial class ArtistAlbums : QnSMusicStore.Contracts.Business.App.IArtistAlbums
	{
		static ArtistAlbums()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public ArtistAlbums()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public void CopyProperties(QnSMusicStore.Contracts.Business.App.IArtistAlbums other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				Master.CopyProperties(other.Master);
				ClearDetails();
				foreach (var detail in other.Details)
				{
					AddDetail(detail);
				}
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSMusicStore.Contracts.Business.App.IArtistAlbums other, ref bool handled);
		partial void AfterCopyProperties(QnSMusicStore.Contracts.Business.App.IArtistAlbums other);
	}
}
namespace QnSMusicStore.Transfer.Business.App
{
	partial class ArtistAlbums : RelationModel<QnSMusicStore.Contracts.Persistence.App.IArtist, QnSMusicStore.Transfer.Persistence.App.Artist, QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Transfer.Persistence.App.Album>
	{
	}
}
namespace QnSMusicStore.Transfer.Business.Account
{
	using System.Text.Json.Serialization;
	public partial class AppAccess : QnSMusicStore.Contracts.Business.Account.IAppAccess
	{
		static AppAccess()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public AppAccess()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		[JsonIgnore]
		public QnSMusicStore.Contracts.Persistence.Account.IIdentity Identity
		{
			get
			{
				OnIdentityReading();
				return _identity;
			}
			set
			{
				bool handled = false;
				OnIdentityChanging(ref handled, ref _identity);
				if (handled == false)
				{
					this._identity = value;
				}
				OnIdentityChanged();
			}
		}
		private QnSMusicStore.Contracts.Persistence.Account.IIdentity _identity;
		partial void OnIdentityReading();
		partial void OnIdentityChanging(ref bool handled, ref QnSMusicStore.Contracts.Persistence.Account.IIdentity _identity);
		partial void OnIdentityChanged();
		[JsonIgnore]
		public System.Collections.Generic.IEnumerable<QnSMusicStore.Contracts.Persistence.Account.IRole> Roles
		{
			get
			{
				OnRolesReading();
				return _roles;
			}
			set
			{
				bool handled = false;
				OnRolesChanging(ref handled, ref _roles);
				if (handled == false)
				{
					this._roles = value;
				}
				OnRolesChanged();
			}
		}
		private System.Collections.Generic.IEnumerable<QnSMusicStore.Contracts.Persistence.Account.IRole> _roles;
		partial void OnRolesReading();
		partial void OnRolesChanging(ref bool handled, ref System.Collections.Generic.IEnumerable<QnSMusicStore.Contracts.Persistence.Account.IRole> _roles);
		partial void OnRolesChanged();
		public void CopyProperties(QnSMusicStore.Contracts.Business.Account.IAppAccess other)
		{
			if (other == null)
			{
				throw new System.ArgumentNullException(nameof(other));
			}
			bool handled = false;
			BeforeCopyProperties(other, ref handled);
			if (handled == false)
			{
				Id = other.Id;
				Timestamp = other.Timestamp;
				Identity = other.Identity;
				Roles = other.Roles;
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSMusicStore.Contracts.Business.Account.IAppAccess other, ref bool handled);
		partial void AfterCopyProperties(QnSMusicStore.Contracts.Business.Account.IAppAccess other);
	}
}
namespace QnSMusicStore.Transfer.Business.Account
{
	partial class AppAccess : IdentityModel
	{
	}
}
