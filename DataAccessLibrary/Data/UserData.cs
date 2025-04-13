using DataAccessLibrary.DbAccess;
using DataAccessLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary.Data;

public class UserData : IUserData
{
    private readonly ISqlDataAccess _db;

    public UserData(ISqlDataAccess db)
    {
        _db = db;
    }

    public Task<IEnumerable<UserModel>> GetUsers() =>
        // since you have to pass something for type U, pass an empty object
        _db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });

    // potentially nullable
    public async Task<UserModel?> GetUser(int id)
    {
        var results = await _db.LoadData<UserModel, dynamic>(
            storedProcedure: "dbo.spUser_Get",
            new { Id = id });
        return results.FirstOrDefault();
    }

    public Task InsertUser(UserModel user) =>
        _db.SaveData("dbo.spUser_Insert", new { user.Username, user.Password }); // notice how no Username = user.Username, since property name is same as parameter name

    public Task UpdateUser(UserModel user) =>
        _db.SaveData("dbo.spUser_Update", user); // here I can just pass the whole object since the parameter names match the property names of the whole object

    public Task DeleteUser(int id) =>
        _db.SaveData("dbo.spUser_Delete", new { Id = id });
}
