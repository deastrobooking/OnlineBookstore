# ?? Bob's Book Nook - Setup Instructions

## Project Overview
ASP.NET Web Forms application for managing book inventory with XML upload and image management capabilities.

## ? Setup Complete!

Your Bob's Book Nook project has been fully implemented with:

### Files Created/Updated:
1. **App_Code/myDatabaseConnection.cs** - Database connection handler
2. **Login.aspx** + **Login.aspx.cs** - User authentication
3. **Admin.aspx** + **Admin.aspx.cs** - Administration interface
4. **App_Data/sample-books.xml** - Sample XML data for testing
5. **Web.config** - Application configuration

### Folder Structure:
```
OnlineBookstore/
??? App_Code/
?   ??? myDatabaseConnection.cs
??? App_Data/
?   ??? sample-books.xml (sample data)
?   ??? BobsBookNook.mdf (created on first run)
??? Img/ (book cover images)
??? Web.config
??? Login.aspx
??? Login.aspx.cs
??? Admin.aspx
??? Admin.aspx.cs
```

## ?? How to Run

### 1. **Start the Application**
   - Open the project in Visual Studio
   - Press **F5** or click **Start**
 - Navigate to `Login.aspx`

### 2. **Login Process**
   - Enter an owner ID (e.g., "admin")
   - Re-enter the same ID
   - Click **Submit**
   - Owner ID will be saved with an underscore (e.g., "admin_")

### 3. **Admin Operations**

#### Upload Images (Do This First!)
1. Click **Browse** next to "Upload Images"
2. Select an image file (`.jpg`, `.png`, `.gif`)
3. Click **Load Images**
4. Repeat for each image you want to upload
5. Images will be saved to the `Img/` folder

#### Upload XML Data
1. Click **Browse** next to "Upload XML Data"
2. Select the XML file (use `App_Data/sample-books.xml` for testing)
3. Click **Load XML**
4. Data will be parsed and inserted into the database

#### View Inventory
1. Click **View Inventory** to display all books in a GridView
2. See book images, titles, authors, categories, ISBNs, and descriptions

#### Clear Database
1. Click **Clear Database** to drop and recreate the table
2. Useful for starting fresh

#### Reset User
1. Click **Reset User** to return to login page

## ?? Database Schema

**Table: `{ownerID}_BOOKS`**

| Column      | Type         | Description |
|-------------|--------------|------------------------|
| Title       | CHAR(64)     | Book title          |
| ISBN        | CHAR(14)     | ISBN (unique)          |
| Author    | CHAR(64)     | Author name      |
| Category    | CHAR(48)     | Book category     |
| Image   | CHAR(128)    | Image path        |
| Description | CHAR(255)    | Book description     |

## ?? XML File Format

```xml
<?xml version="1.0" encoding="utf-8"?>
<BOOKLIST>
  <BOOK>
    <TITLE>Book Title</TITLE>
    <ISBN>978-XXXXXXXXXX</ISBN>
    <AUTHOR>Author Name</AUTHOR>
 <CATEGORY>Category</CATEGORY>
    <JACKETURL>image-filename.jpg</JACKETURL>
    <DESCRIPTION>Book description...</DESCRIPTION>
  </BOOK>
</BOOKLIST>
```

## ?? Technical Details

### Features Implemented:
- ? Login validation with ownerID storage
- ? Image upload (one at a time)
- ? XML parsing and database insertion
- ? Dynamic table creation per user
- ? GridView with image display
- ? Progress logging
- ? Error handling
- ? SQL injection prevention (single quotes escaping)

### Technologies:
- ASP.NET Web Forms
- C# Code-Behind
- SQL Server LocalDB
- ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)
- XML File Processing
- File Upload Controls

## ?? Troubleshooting

### Database Connection Issues
- Ensure SQL Server LocalDB is installed
- Database file will be created automatically in `App_Data/`

### Image Not Displaying
- Verify images are uploaded before XML data
- Check that image filenames in XML match uploaded files
- Image paths should be relative: `\Img\filename.jpg`

### Login Redirect Loop
- Ensure `App_Data/ownerID.txt` is being created
- Check folder permissions for `App_Data/`

### File Upload Size Limit
- Default max file size is 10MB
- Adjust in Web.config if needed (maxRequestLength setting)

## ?? Testing with Sample Data

1. **Create test images**: Place any `.jpg` files in the `Img/` folder manually, or upload them one at a time
2. **Use provided XML**: `App_Data/sample-books.xml` has 5 sample books
3. **Upload in order**: Images first, then XML
4. **View results**: Click "View Inventory"

### Sample Book Images Needed:
For the sample XML, create or download these images:
- great-gatsby.jpg
- mockingbird.jpg
- 1984.jpg
- pride-prejudice.jpg
- catcher-rye.jpg

## ?? Assignment Checklist

Before submission, verify:
- [x] `lstHidden.Visible = false` (already set in Admin.aspx)
- [x] Unused `using` statements removed
- [x] `Img` folder at same level as `App_Data`
- [ ] Test with `/Admin.aspx` URL
- [ ] All functionality working (login, upload, display)
- [ ] No compilation errors
- [ ] GridView displays images and data correctly

## ?? Key Classes & Methods

### myDatabaseConnection.cs
- `executeSQL()` - Execute SQL and bind to GridView

### Login.aspx.cs
- `btnSubmit_Click()` - Validate and save ownerID

### Admin.aspx.cs
- `Page_Load()` - Initialize page and check authentication
- `checkTables()` - Verify/create database table
- `btnLoadImages_Click()` - Handle image upload (one file at a time)
- `btnLoadXML_Click()` - Upload and parse XML file
- `decode()` - Parse XML and insert into database
- `stripTags()` - Remove XML tags from fields
- `btnViewInventory_Click()` - Display all books
- `FormatImageUrl()` - Format image paths for GridView

## ?? Success!

Your Bob's Book Nook application is ready to use. Upload book covers and XML data to see it in action!

---

**Created for ITWP 2300 - Bob's Book Nook Project 1**
