using CurdAPI.Data;
using CurdAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CurdAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TodoListController : ControllerBase
    {
        private readonly AppDbContext appDbContext;

        public TodoListController(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }

        //Read Todo List
        [HttpGet]
        public async Task<ActionResult<List<TodoList>>> GetTodoList()
        {
            var list = await appDbContext.TodoList.ToListAsync();
            return Ok(list);
        }

        //Add A List
        [HttpPost]
        public async Task<ActionResult<List<TodoList>>> AddTodoList(TodoList newTodoList)
        {
            if (newTodoList != null)
            {
                appDbContext.TodoList.Add(newTodoList);
                await appDbContext.SaveChangesAsync();


                var respnose = await appDbContext.TodoList.ToListAsync();
                return Ok(respnose);
            }
            return BadRequest("Error Todo List Cannot be added !");
        }

        //Read single TodoList
        [HttpGet("{id:int}")]
        public async Task<ActionResult<TodoList>> GetTodoList(int id)
        {
            var TodoListData = await appDbContext.TodoList.FirstOrDefaultAsync(e => e.Id == id);
            if (TodoListData != null)
            {
                return Ok(TodoListData);
            }
            return NotFound("TodoList Not Found in the Database!");
        }

        //Update TodoList
        [HttpPut]
        public async Task<ActionResult<TodoList>> UpdateCustomer(TodoList updateTodoList)
        {
            if (updateTodoList != null)
            {
                var todoList = await appDbContext.TodoList.FirstOrDefaultAsync(e => e.Id == updateTodoList.Id);
                if (todoList != null)
                {
                    todoList.Text = updateTodoList.Text;
                    todoList.IsDone = updateTodoList.IsDone;
      
                
                    await appDbContext.SaveChangesAsync();

                    var response = await appDbContext.TodoList.ToListAsync();
                    return Ok(response);
                }
                return NotFound();
            }
            return BadRequest();
        }

        //Delete TodoList
        [HttpDelete]
        public async Task<ActionResult<List<TodoList>>> Deletelist(int id)
        {
            var list = await appDbContext.TodoList.FirstOrDefaultAsync(e => e.Id == id);
            if (list != null)
            {
                appDbContext.TodoList.Remove(list);
                await appDbContext.SaveChangesAsync();

                var response = await appDbContext.TodoList.ToListAsync();
                return Ok(response);
            }
            return BadRequest();
        }
    }
}
