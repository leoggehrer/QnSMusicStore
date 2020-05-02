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
				RowVersion = other.RowVersion;
				FirstItem.CopyProperties(other.FirstItem);
				ClearSecondItems();
				foreach (var item in other.SecondItems)
				{
					AddSecondItem(item);
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
			return Id == other.Id && IsEqualsWith(RowVersion, other.RowVersion) && IsEqualsWith(FirstItem, other.FirstItem) && IsEqualsWith(SecondItems, other.SecondItems);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, RowVersion, FirstItem, SecondItems);
		}
	}
}
namespace QnSMusicStore.Logic.Entities.Business.App
{
	partial class AlbumTracks : OneToManyObject<QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Logic.Entities.Persistence.App.Album, QnSMusicStore.Contracts.Persistence.App.ITrack, QnSMusicStore.Logic.Entities.Persistence.App.Track>
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
				RowVersion = other.RowVersion;
				FirstItem.CopyProperties(other.FirstItem);
				ClearSecondItems();
				foreach (var item in other.SecondItems)
				{
					AddSecondItem(item);
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
			return Id == other.Id && IsEqualsWith(RowVersion, other.RowVersion) && IsEqualsWith(FirstItem, other.FirstItem) && IsEqualsWith(SecondItems, other.SecondItems);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, RowVersion, FirstItem, SecondItems);
		}
	}
}
namespace QnSMusicStore.Logic.Entities.Business.App
{
	partial class ArtistAlbums : OneToManyObject<QnSMusicStore.Contracts.Persistence.App.IArtist, QnSMusicStore.Logic.Entities.Persistence.App.Artist, QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.Logic.Entities.Persistence.App.Album>
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
				RowVersion = other.RowVersion;
				FirstItem.CopyProperties(other.FirstItem);
				ClearSecondItems();
				foreach (var item in other.SecondItems)
				{
					AddSecondItem(item);
				}
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
			return Id == other.Id && IsEqualsWith(RowVersion, other.RowVersion) && IsEqualsWith(FirstItem, other.FirstItem) && IsEqualsWith(SecondItems, other.SecondItems);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, RowVersion, FirstItem, SecondItems);
		}
	}
}
namespace QnSMusicStore.Logic.Entities.Business.Account
{
	partial class AppAccess : OneToManyObject<QnSMusicStore.Contracts.Persistence.Account.IIdentity, QnSMusicStore.Logic.Entities.Persistence.Account.Identity, QnSMusicStore.Contracts.Persistence.Account.IRole, QnSMusicStore.Logic.Entities.Persistence.Account.Role>
	{
	}
}
namespace QnSMusicStore.Logic.Entities.Business.Account
{
	using System;
	partial class IdentityUser : QnSMusicStore.Contracts.Business.Account.IIdentityUser
	{
		static IdentityUser()
		{
			ClassConstructing();
			ClassConstructed();
		}
		static partial void ClassConstructing();
		static partial void ClassConstructed();
		public IdentityUser()
		{
			Constructing();
			Constructed();
		}
		partial void Constructing();
		partial void Constructed();
		public void CopyProperties(QnSMusicStore.Contracts.Business.Account.IIdentityUser other)
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
				RowVersion = other.RowVersion;
				FirstItem.CopyProperties(other.FirstItem);
				SecondItem.CopyProperties(other.SecondItem);
			}
			AfterCopyProperties(other);
		}
		partial void BeforeCopyProperties(QnSMusicStore.Contracts.Business.Account.IIdentityUser other, ref bool handled);
		partial void AfterCopyProperties(QnSMusicStore.Contracts.Business.Account.IIdentityUser other);
		public override bool Equals(object obj)
		{
			if (!(obj is QnSMusicStore.Contracts.Business.Account.IIdentityUser instance))
			{
				return false;
			}
			return base.Equals(instance) && Equals(instance);
		}
		protected bool Equals(QnSMusicStore.Contracts.Business.Account.IIdentityUser other)
		{
			if (other == null)
			{
				return false;
			}
			return Id == other.Id && IsEqualsWith(RowVersion, other.RowVersion) && IsEqualsWith(FirstItem, other.FirstItem) && IsEqualsWith(SecondItem, other.SecondItem);
		}
		public override int GetHashCode()
		{
			return HashCode.Combine(Id, RowVersion, FirstItem, SecondItem);
		}
	}
}
namespace QnSMusicStore.Logic.Entities.Business.Account
{
	partial class IdentityUser : OneToOneObject<QnSMusicStore.Contracts.Persistence.Account.IIdentity, QnSMusicStore.Logic.Entities.Persistence.Account.Identity, QnSMusicStore.Contracts.Persistence.Account.IUser, QnSMusicStore.Logic.Entities.Persistence.Account.User>
	{
	}
}
