using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebSite.Models
{

    public class ApplicationContext : IdentityDbContext<AppUser>
    {
        public DbSet<Departments> Departments { get; set; }
        public DbSet<Otdel> Otdel { get; set; }
        public DbSet<ListOfResources> ListOfResources { get; set; }
        public DbSet<Kollegia> Kollegia { get; set; }
        public DbSet<Resume> Resume { get; set; }
        public DbSet<WorkList> WorkList { get; set; }
        public DbSet<Positions> Positions { get; set; }
        public DbSet<MyzeiCategory> MyzeiCategory { get; set; }
        public DbSet<Myzei> Myzei { get; set; }
        public DbSet<MyzeiZdanie> MyzeiZdanie { get; set; }
        public DbSet<EducationList> EducationList { get; set; }
        public DbSet<OtdelDetali> OtdelDetali { get; set; }
        public DbSet<Obrashenie> Obrashenie { get; set; }
        public DbSet<ContactsPodvedPodrz> ContactsPodvedPodrz { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options): base(options)
        {
            Database.EnsureCreated();
        }
    }

    public class Obrashenie
    {
        public int Id { get; set; }
        public string Theme { get; set; }
        public string FIO { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public DateTime CreateDate { get; set; }
    }

    public class MyzeiZdanie
    {
        public int Id { get; set; }
        [Display(Name = "Название музея")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        
        [Display(Name = "Профиль  музея")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Profil { get; set; }
        [Display(Name = "Область")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Oblast { get; set; }
        [Display(Name = "Тип здания")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string TipZdania { get; set; }

        [Display(Name = "Примечание")]
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public MyzeiZdanie()
        {
            Lang = 1;
        }


    }
    public class MyzeiCategory
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }

        [Display(Name = "Примечание")]

        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public MyzeiCategory()
        {
            Lang = 1;
        }


    }
    public class Myzei
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        public int MyzeiCategoryId { get; set; }
        [Display(Name = "Категория")]
        [Required(ErrorMessage = "Обязательное поле")]
        public MyzeiCategory MyzeiCategory { get; set; }

        [Display(Name = "Показатель")]
        public string God { get; set; }
        [Display(Name = "Фактический год")]
        public string FactYear { get; set; }
        [Display(Name = "Примечание")]
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public Myzei()
        {
            Lang = 1;
        }


    }
    public class EducationList
    {
        public int Id { get; set; }
         
        [Display(Name = "Учебное заведение")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        [Display(Name = "Специальность")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Spesialnost { get; set; }
        [Display(Name = "Год")]
        [Required(ErrorMessage = "Обязательное поле")]
        public int Years { get; set; }
        public int ResumeId { get; set; }
        public Resume Resume { get; set; }

        [Display(Name = "Примечание")]
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public EducationList()
        {
            Lang = 1;
        }


    }
    public class WorkList
    {
        public int Id { get; set; }
        [Display(Name = "Год и месяц вступления и ухода")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Termine { get; set; }
        [Display(Name = "Наименование учреждения, предприятия, организации")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string OrgName { get; set; }

        [Display(Name = "Занимаемая должность")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Positions { get; set; }

        public int ResumeId { get; set; }
        public Resume Resume { get; set; }

        [Display(Name = "Примечание")]
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public WorkList()
        {
            Lang = 1;
        }


    }
    public class Resume
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        [Display(Name = "Фамилия")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string LastName { get; set; }
        [Display(Name = "Имя")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string FirstName { get; set; }
        [Display(Name = "Отчество")]
        public string PatronomicName { get; set; }
        [Display(Name = "Дата рождения")]
        [Required(ErrorMessage = "Обязательное поле")]
        public DateTime BirthDay { get; set; }
        [Display(Name = "Место рождения")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string BirthPlace { get; set; }
        [Display(Name = "Национальность")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Nation { get; set; }
        [Display(Name = "Гражданство")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Citizen { get; set; }
        [Display(Name = "Образование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Education { get; set; }

        [Display(Name = "Языки")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Languages { get; set; }

        [Display(Name = "Примечание")]
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public Resume()
        {
            Lang = 1;
        }


    }
    public class ContactsPodvedPodrz
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        [Display(Name = "Директор")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Director { get; set; }
        [Display(Name = "Адрес")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Address { get; set; }

        [Display(Name = "Контакты")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Contacts { get; set; }
        [Display(Name = "Телефон")]
        public string Phone { get; set; }
        [Display(Name = "Факс")]
        public string Fax { get; set; }
        [Display(Name = "Е-майл")]
        public string Email { get; set; }

        [Display(Name = "Примечание")]
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public ContactsPodvedPodrz()
        {
            Lang = 1;
        }
    }

    public class ListOfResources
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }

        [Display(Name = "Сылка")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Links { get; set; }
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
    }

    public class Kollegia
    {
        public int Id { get; set; }
        [Display(Name = "Ф.И.О.")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        [Display(Name = "Должность")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Positions { get; set; }

        [Display(Name = "Примечание")]

        public string Desc { get; set; }
        public int Lang { get; set; } = 1; 

    }
    public class Departments
    {
        public int Id { get; set; }
        [Display(Name="Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        [Display(Name = "Директор")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Director { get; set; }
        [Display(Name = "Адрес")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Address { get; set; }
        [Display(Name= "Контакты")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Contacts { get; set; }
        [Display(Name = "Телефон")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Phone { get; set; }
        [Display(Name = "Факс")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Fax { get; set; }
        [Display(Name = "Е-майл")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Email { get; set; } 
        public int Lang { get; set; } = 1;
        public Departments()
        {
            Lang = 1;
        }


    }
    public class Otdel
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        
        [Display(Name = "Примечание")]
       
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public Otdel()
        {
            Lang = 1;
        }


    }

    public class Positions
    {
        public int Id { get; set; }
        [Display(Name = "Наименование")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }

        [Display(Name = "Примечание")]
     
        public string Desc { get; set; }
        public int Lang { get; set; } = 1;
        public Positions()
        {
            Lang = 1;
        }
    }

    public class OtdelDetali
    {
        public int Id { get; set; }
        [Display(Name = "Ф.И.О.")]
        [Required(ErrorMessage = "Обязательное поле")]
        public string Name { get; set; }
        [Display(Name = "Подразделение")]
        [Required(ErrorMessage = "Обязательное поле")]
        public int OtdelId { get; set; }
        [Display(Name = "Подразделение")]
        public Otdel Otdel { get; set; }

        [Display(Name = "Должность")]
        [Required(ErrorMessage = "Обязательное поле")]
        public int PositionsId { get; set; }
        [Display(Name = "Должность")]
        public Positions Positions { get; set; }
        [Display(Name = "Рабочий телефон")]
        public string WorkPhone { get; set; }
        [Display(Name = "Мобильный телефон")]
        public string Phone { get; set; }
        [Display(Name = "Факс")]
        public string Fax { get; set; }
        [Display(Name = "Е-майл")]
        public string Email { get; set; }
        public int Lang { get; set; } = 1;
        public OtdelDetali()
        {
            Lang = 1;
        }


    }

    public class AppUser : IdentityUser
    {
        public int Year { get; set; }
    }


}
