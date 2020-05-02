namespace QnSMusicStore.Logic.DataContext.Db
{
	using Microsoft.EntityFrameworkCore;
	using Microsoft.EntityFrameworkCore.Metadata.Builders;
	partial class QnSMusicStoreDbContext : GenericDbContext
	{
		protected DbSet<Entities.Persistence.App.Album> AlbumSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.App.Artist> ArtistSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.App.Genre> GenreSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.App.Track> TrackSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.ActionLog> ActionLogSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.Identity> IdentitySet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.IdentityXRole> IdentityXRoleSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.LoginSession> LoginSessionSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.Role> RoleSet
		{
			get;
			set;
		}
		protected DbSet<Entities.Persistence.Account.User> UserSet
		{
			get;
			set;
		}
		public override DbSet<E> Set<I, E>()
		{
			DbSet<E> result = null;
			if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IAlbum))
			{
				result = AlbumSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IArtist))
			{
				result = ArtistSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.IGenre))
			{
				result = GenreSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.App.ITrack))
			{
				result = TrackSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IActionLog))
			{
				result = ActionLogSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IIdentity))
			{
				result = IdentitySet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IIdentityXRole))
			{
				result = IdentityXRoleSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.ILoginSession))
			{
				result = LoginSessionSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IRole))
			{
				result = RoleSet as DbSet<E>;
			}
			else if (typeof(I) == typeof(QnSMusicStore.Contracts.Persistence.Account.IUser))
			{
				result = UserSet as DbSet<E>;
			}
			return result;
		}
		partial void DoModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Entities.Persistence.App.Album>().ToTable(nameof(Entities.Persistence.App.Album), nameof(Entities.Persistence.App)).HasKey(nameof(Entities.Persistence.App.Album.Id));
			modelBuilder.Entity<Entities.Persistence.App.Album>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.App.Album>());
			modelBuilder.Entity<Entities.Persistence.App.Artist>().ToTable(nameof(Entities.Persistence.App.Artist), nameof(Entities.Persistence.App)).HasKey(nameof(Entities.Persistence.App.Artist.Id));
			modelBuilder.Entity<Entities.Persistence.App.Artist>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.App.Artist>());
			modelBuilder.Entity<Entities.Persistence.App.Genre>().ToTable(nameof(Entities.Persistence.App.Genre), nameof(Entities.Persistence.App)).HasKey(nameof(Entities.Persistence.App.Genre.Id));
			modelBuilder.Entity<Entities.Persistence.App.Genre>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.App.Genre>());
			modelBuilder.Entity<Entities.Persistence.App.Track>().ToTable(nameof(Entities.Persistence.App.Track), nameof(Entities.Persistence.App)).HasKey(nameof(Entities.Persistence.App.Track.Id));
			modelBuilder.Entity<Entities.Persistence.App.Track>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.App.Track>());
			modelBuilder.Entity<Entities.Persistence.Account.ActionLog>().ToTable(nameof(Entities.Persistence.Account.ActionLog), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.ActionLog.Id));
			modelBuilder.Entity<Entities.Persistence.Account.ActionLog>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.ActionLog>());
			modelBuilder.Entity<Entities.Persistence.Account.Identity>().ToTable(nameof(Entities.Persistence.Account.Identity), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.Identity.Id));
			modelBuilder.Entity<Entities.Persistence.Account.Identity>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.Identity>());
			modelBuilder.Entity<Entities.Persistence.Account.IdentityXRole>().ToTable(nameof(Entities.Persistence.Account.IdentityXRole), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.IdentityXRole.Id));
			modelBuilder.Entity<Entities.Persistence.Account.IdentityXRole>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.IdentityXRole>());
			modelBuilder.Entity<Entities.Persistence.Account.LoginSession>().ToTable(nameof(Entities.Persistence.Account.LoginSession), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.LoginSession.Id));
			modelBuilder.Entity<Entities.Persistence.Account.LoginSession>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.LoginSession>());
			modelBuilder.Entity<Entities.Persistence.Account.Role>().ToTable(nameof(Entities.Persistence.Account.Role), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.Role.Id));
			modelBuilder.Entity<Entities.Persistence.Account.Role>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.Role>());
			modelBuilder.Entity<Entities.Persistence.Account.User>().ToTable(nameof(Entities.Persistence.Account.User), nameof(Entities.Persistence.Account)).HasKey(nameof(Entities.Persistence.Account.User.Id));
			modelBuilder.Entity<Entities.Persistence.Account.User>().Property(p => p.RowVersion).IsRowVersion();
			ConfigureEntityType(modelBuilder.Entity<Entities.Persistence.Account.User>());
		}
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Album> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Artist> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Genre> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.App.Track> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.ActionLog> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.Identity> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.IdentityXRole> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.LoginSession> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.Role> entityTypeBuilder);
		partial void ConfigureEntityType(EntityTypeBuilder<Entities.Persistence.Account.User> entityTypeBuilder);
	}
}
