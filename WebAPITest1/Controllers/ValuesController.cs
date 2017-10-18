using System.Collections.Generic;
using System.Web.Http;
using System.Data.Entity;
using WebAPITest1.Models;

namespace WebAPITest1.Controllers
{
    public class ValuesController : ApiController
    {
        MusicContext db;

        public IEnumerable<Music> GetMusic()
        {
            return db.Music;
        }

        public Music GetMusic(int id)
        {
            Music music = db.Music.Find(id);
            return music;
        }

        [HttpPost]
        public void CreateMusic([FromBody]Music music)
        {
            db.Music.Add(music);
            db.SaveChanges();
        }

        [HttpPut]
        public void EditMusic(int id, [FromBody]Music music)
        {
            if (id == music.Id)
            {
                db.Entry(music).State = EntityState.Modified;

                db.SaveChanges();
            }
        }

        public void DeleteMusic(int id)
        {
            Music music = db.Music.Find(id);
            if (music != null)
            {
                db.Music.Remove(music);
                db.SaveChanges();
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}