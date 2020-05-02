namespace QnSMusicStore.AspMvc.Models.Business.App
{
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
	}
}
namespace QnSMusicStore.AspMvc.Models.Business.App
{
	partial class AlbumTracks : OneToManyModel<QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.AspMvc.Models.Persistence.App.Album, QnSMusicStore.Contracts.Persistence.App.ITrack, QnSMusicStore.AspMvc.Models.Persistence.App.Track>
	{
	}
}
namespace QnSMusicStore.AspMvc.Models.Business.App
{
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
	}
}
namespace QnSMusicStore.AspMvc.Models.Business.App
{
	partial class ArtistAlbums : OneToManyModel<QnSMusicStore.Contracts.Persistence.App.IArtist, QnSMusicStore.AspMvc.Models.Persistence.App.Artist, QnSMusicStore.Contracts.Persistence.App.IAlbum, QnSMusicStore.AspMvc.Models.Persistence.App.Album>
	{
	}
}
namespace QnSMusicStore.AspMvc.Models.Business.Account
{
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
	}
}
namespace QnSMusicStore.AspMvc.Models.Business.Account
{
	partial class AppAccess : OneToManyModel<QnSMusicStore.Contracts.Persistence.Account.IIdentity, QnSMusicStore.AspMvc.Models.Persistence.Account.Identity, QnSMusicStore.Contracts.Persistence.Account.IRole, QnSMusicStore.AspMvc.Models.Persistence.Account.Role>
	{
	}
}
namespace QnSMusicStore.AspMvc.Models.Business.Account
{
	public partial class IdentityUser : QnSMusicStore.Contracts.Business.Account.IIdentityUser
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
	}
}
namespace QnSMusicStore.AspMvc.Models.Business.Account
{
	partial class IdentityUser : OneToOneModel<QnSMusicStore.Contracts.Persistence.Account.IIdentity, QnSMusicStore.AspMvc.Models.Persistence.Account.Identity, QnSMusicStore.Contracts.Persistence.Account.IUser, QnSMusicStore.AspMvc.Models.Persistence.Account.User>
	{
	}
}
