# CosmeticOrder_Agile


## Changing ConnectionString at ~/CosmeticOrder_Agile/Cosmetic/Cosmetic/appsettings.json

<code>
  "ConnectionStrings": {
    "WebMyPham": "User ID=netcore;Password=netcore;Host=localhost;Port=5432;Database=mypham;"
  },
</code>

## Changing Database Source at ~/CosmeticOrder_Agile/Cosmetic/Cosmetic/Startup.cs

- Using PostgreSQL Entity Framework Core

<code> 
  services.AddEntityFrameworkNpgsql().AddDbContext<MyPhamContext>(options => opions.UseNpgsql(Configuration.GetConnectionString("WebMyPham")));
</code>

- Using Microsoft SQL Server

<code>
  services.AddDbContext<MyPhamContext>(options => options.UseSqlServer(Configuration.GetConnectionString("WebMyPham")));       
</code>

## Changing Database source at ~/CosmeticOrder_Agile/Cosmetic/Cosmetic/Models/MyPhamContext.cs

<code>
  
 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
                string projectPath = AppDomain.CurrentDomain.BaseDirectory
                .Split(new String[] { 
                    //If you are using Windows, please change @"bin/" into @"bin\"
                    //If you are using Linux, please change @"bin\" into @"bin/"
                    @"bin/"                
                    }, StringSplitOptions.None)[0];
                
                //Just changing connectionstring on file appsettings.json
                IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(projectPath)
                .AddJsonFile("appsettings.json")
                .Build();

                string connectionString = configuration.GetConnectionString("WebMyPham");
                /////////////////////////////////////////////////////////////////////////
                //If you are using PostgreSQL Entity Framework Core
                optionsBuilder.UseNpgsql(connectionString);
                
                //If you are using Microsoft SQL Server
                //optionsBuilder.UseSqlServer(connectionString);
                //////////////////////////////////////////////////////////////////////////
            }
        }
 </code>
