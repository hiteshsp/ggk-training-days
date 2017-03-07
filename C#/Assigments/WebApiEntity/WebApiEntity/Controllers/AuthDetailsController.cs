using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web.Http;

namespace WebApiEntity.Controllers
{
    /// <summary>
    /// Controller class where the http methods exist.
    /// </summary>
    public class AuthDetailsController : ApiController
    {
        // Common object for the entire class.
        private AuthenticationEntities entityObj = new AuthenticationEntities();

        /// <summary>
        /// Api for Get method which get's specific user with the given id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IHttpActionResult GetAuthDetail(string id)
        {
            AuthDetail authDetail = entityObj.AuthDetails.Find(id);

            return Ok(authDetail);
        }
        
        /// <summary>
        /// Api for post data from body.
        /// </summary>
        /// <param name="authDetail"></param>
        /// <returns></returns>
        public IHttpActionResult PostAuthDetail([FromBody]AuthDetail authDetail)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            entityObj.AuthDetails.Add(authDetail);

            try
            {
                entityObj.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (AuthDetailExists(authDetail.username))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = authDetail.username }, authDetail);
        }

        /// <summary>
        /// Api which checks the user's existence.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        private bool AuthDetailExists(string id)
        {
            return entityObj.AuthDetails.Count(e => e.username == id) > 0;
        }
    }
}