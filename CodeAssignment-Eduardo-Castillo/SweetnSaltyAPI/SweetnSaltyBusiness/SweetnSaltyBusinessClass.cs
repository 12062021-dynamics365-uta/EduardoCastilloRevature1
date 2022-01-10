using System;
using System.Threading.Tasks;
using SweetnSaltyDbAccess;
using SweetnSaltyModels;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace SweetnSaltyBusiness
{
    public class SweetnSaltyBusinessClass : ISweetnSaltyBusinessClass
    {
        private readonly ISweetnSaltyDbAccessClass _dbAccess;
        private readonly IMapper _mapper;

        public SweetnSaltyBusinessClass(ISweetnSaltyDbAccessClass Dbaccess, IMapper mapper)//you need a reference to the DbAccess Layer 
        {
            this._mapper = mapper;
            _dbAccess = Dbaccess;
        }

        public async Task<Flavor> PostFlavor(string flavor)
        {
            SqlDataReader dr = await this._dbAccess.PostFlavor(flavor);
            if (dr.Read())
            {
                Flavor f = this._mapper.EntityToFlavor(dr);
                return f;
            }
            else
                return null;
        }

        public async Task<Person> PostPerson(string fname, string lname, string flavor)
        {
            SqlDataReader dr = await this._dbAccess.FindPerson(fname, lname);           

            Person p = null;
            if (dr.Read())
            {
                p = this._mapper.EntityToPerson(dr);
            }
                
            SqlDataReader dr1 = await this._dbAccess.FindFlavor(flavor);
            Flavor f = new Flavor();
            if (dr1.Read())
            {
                f = this._mapper.EntityToFlavor(dr1);
            }              

            this._dbAccess.LikeFlavor(p.PersonId, f.FlavorId);
            p.LikeAFlavor(f);
            return p;
        }

        public async Task<Person> PostNewPerson(string fname, string lname, string flavor)
        {
            SqlDataReader dr = await this._dbAccess.PostPerson(fname, lname);

            Person p = null;
            if (dr.Read())
            {
                p = this._mapper.EntityToPerson(dr);
            }

            SqlDataReader dr1 = await this._dbAccess.FindFlavor(flavor);
            Flavor f = new Flavor();
            if (dr1.Read())
            {
                f = this._mapper.EntityToFlavor(dr1);
            }

            this._dbAccess.LikeFlavor(p.PersonId, f.FlavorId);
            p.LikeAFlavor(f);
            return p;
        }

        public async Task<Person> GetPerson(string fname, string lname)
        {
            SqlDataReader dr = await this._dbAccess.FindPerson(fname, lname);
            if (dr.Read())
            {
                Person p = this._mapper.EntityToPerson(dr);
                return p;
            }
            else
                return null;
        }

        public async Task<Person> GetPerson(int personId)
        {
            SqlDataReader dr = await this._dbAccess.FindPerson(personId);
            Person p = null;
            if (dr.Read())
            {
                p = this._mapper.EntityToPerson(dr);
            }
            p.Flavors = await FindPersonFlavors(personId);
            return p;
        }

        public async Task<List<Flavor>> FindPersonFlavors(int personId)
        {
            SqlDataReader dr = await this._dbAccess.FindPersonFlavors(personId);
            List<Flavor> flavors = new List<Flavor>();
            while(dr.Read())
            {
                Flavor f = this._mapper.EntityToFlavor(dr);
                flavors.Add(f);
            }
            return flavors;
        }

        public async Task<List<Flavor>> GetAllFlavors()
        {
            SqlDataReader dr = await this._dbAccess.GetFlavors();
            List<Flavor> flavors = new List<Flavor>();
            while (dr.Read())
            {
                Flavor f = this._mapper.EntityToFlavor(dr);
                flavors.Add(f);
            }
            return flavors;
        }
    }
}
