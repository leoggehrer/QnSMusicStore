namespace QnSMusicStore.Logic.Entities.Business.App
{
	using System;
	partial class AlbumTracks : QnSMusicStore.Contracts.Business.App.IAlbumTracks
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
		public override bool Equals(object obj)
		{
			if (!(obj is QnSMusicStore.Contracts.Business.App.IAlbumTracks instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSMusicStore.Contracts.Business.App.IAlbumTracks other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Master, other.Master) && IsEqualsWith(Details, other.Details);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Master, Details);
		}
	}
}
namespace QnSMusicStore.Logic.Entities.Business.App
{
	partial class AlbumTracks : RelationObject<QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Logic.Entities.Persistence.App.Album, QnSMusicStore.Contracts.Persistence.App.ITrack, QnSMusicStore.Logic.Entities.Persistence.App.Track>
	{
	}
}
namespace QnSMusicStore.Logic.Entities.Business.App
{
	using System;
	partial class ArtistAlbums : QnSMusicStore.Contracts.Business.App.IArtistAlbums
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
		public override bool Equals(object obj)
		{
			if (!(obj is QnSMusicStore.Contracts.Business.App.IArtistAlbums instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSMusicStore.Contracts.Business.App.IArtistAlbums other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Master, other.Master) && IsEqualsWith(Details, other.Details);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Master, Details);
		}
	}
}
namespace QnSMusicStore.Logic.Entities.Business.App
{
	partial class ArtistAlbums : RelationObject<QnSMusicStore.Contracts.Persistence.App.IArtist, QnSMusicStore.Logic.Entities.Persistence.App.Artist, QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Logic.Entities.Persistence.App.Album>
	{
	}
}
namespace QnSMusicStore.Logic.Entities.Business.Account
{
	using System;
	partial class AppAccess : QnSMusicStore.Contracts.Business.Account.IAppAccess
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
		public override bool Equals(object obj)
		{
			if (!(obj is QnSMusicStore.Contracts.Business.Account.IAppAccess instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSMusicStore.Contracts.Business.Account.IAppAccess other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(Timestamp, other.Timestamp) && IsEqualsWith(Identity, other.Identity) && IsEqualsWith(Roles, other.Roles);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, Timestamp, Identity, Roles);
		}
	}
}
namespace QnSMusicStore.Logic.Entities.Business.Account
{
	partial class AppAccess : IdentityObject
	{
	}
}
