# WebConfig_Practice_ASPNet

This is a simple ASP.NET Web Forms project created for learning purposes.  
It demonstrates the usage of **Web.config** features such as:

- **Connection Strings**: Connects to a SQL database to fetch data for a GridView.  
- **AppSettings**: Stores small configuration values like `passmarks`.  
- **Compilation & Debug Settings**: Configured via `<compilation>` for debugging.  
- **Custom Errors**: Example of 404 and 500 error redirection.

## Features

1. **Pass/Fail Check**  
   - Enter marks in the TextBox and click the "Check Pass/Fail" button.  
   - The app reads `passmarks` from Web.config and shows pass/fail in a Label.

2. **Display Products/Customers**  
   - Click the "Show Products" button to fetch top 5 customers from the database.  
   - Uses `ShopDB` connection string from Web.config.

## How to Run

1. Open the solution in **Visual Studio**.  
2. Restore NuGet packages if needed.  
3. Ensure **SQL LocalDB** is installed and the `shopping` database exists with a `Customers` table.  
4. Press **F5** to run the project.  

## Notes

- All configuration values are stored in **Web.config** for easy modification.  
- `passmarks` can be changed without editing code.  
- Custom error pages can be configured as needed.
