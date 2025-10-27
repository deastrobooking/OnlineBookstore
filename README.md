# Bob's Book Nook - Online Bookstore

## ?? ITWP 2300 Project 1 - Complete Implementation

This ASP.NET Web Forms application allows administrators to manage a book inventory by uploading XML data and images to a SQL Server database.

## ? Project Status: COMPLETE

All required components have been implemented according to the project specifications.

## ?? Project Structure

```
OnlineBookstore/
??? App_Code/
?   ??? myDatabaseConnection.cs   # Database connection handler
??? App_Data/
?   ??? sample-books.xml              # Sample test data
?   ??? ownerID.txt            # User session (auto-generated)
?   ??? BobsBookNook.mdf    # Database (auto-generated)
??? Img/
?   ??? (uploaded book cover images)
??? PageTemplates/    # Template pages (for future use)
??? Login.aspx / Login.aspx.cs      # Login page
??? Admin.aspx / Admin.aspx.cs      # Administration interface
??? Web.config      # Application configuration
??? SETUP_INSTRUCTIONS.md  # Detailed setup guide
??? QUICK_START.md              # Quick reference guide
??? README.md               # This file
```

## ?? Features Implemented

### ? Authentication System
- Login page with ownerID validation
- Session persistence via file storage
- Automatic redirect to admin page on success

### ? Image Upload System
- Upload book cover images
- File validation and storage
- Progress logging

### ? XML Data Import
- Parse XML book data
- Validate and insert into database
- Error handling and reporting

### ? Database Management
- Dynamic table creation per user
- SQL Server LocalDB integration
- CRUD operations support
- Table clearing/reset functionality

### ? Inventory Display
- GridView with book data
- Image display in grid
- Responsive layout

### ? User Interface
- Modern, clean design
- Progress tracking
- Error messaging
- Styled buttons and controls

## ?? Getting Started

### Prerequisites
- Visual Studio 2019 or later
- SQL Server LocalDB
- .NET Framework 4.8

### Installation
1. Clone or download this repository
2. Open in Visual Studio
3. Press F5 to run
4. Navigate to `/Login.aspx`

### First Time Use
1. **Login**: Enter an ownerID (e.g., "admin")
2. **Upload Images**: Upload book cover images one at a time
3. **Upload XML**: Use the sample XML file in `App_Data/sample-books.xml`
4. **View Inventory**: Click "View Inventory" to see your books

## ?? Documentation

- **SETUP_INSTRUCTIONS.md** - Complete setup and usage guide
- **QUICK_START.md** - Quick reference for common tasks
- **App_Data/sample-books.xml** - Sample XML format

## ?? Technical Stack

- **Framework**: ASP.NET Web Forms
- **Language**: C# (Code-Behind)
- **Database**: SQL Server LocalDB
- **Data Access**: ADO.NET (SqlConnection, SqlCommand, SqlDataAdapter)
- **UI**: HTML, CSS, ASP.NET Server Controls

## ?? Database Schema

Table: `{ownerID}_BOOKS`

| Column | Type | Constraints |
|--------|------|-------------|
| Title | CHAR(64) | |
| ISBN | CHAR(14) | UNIQUE |
| Author | CHAR(64) | |
| Category | CHAR(48) | |
| Image | CHAR(128) | Image path |
| Description | CHAR(255) | |

## ?? XML Format

```xml
<?xml version="1.0" encoding="utf-8"?>
<BOOKLIST>
  <BOOK>
    <TITLE>Book Title</TITLE>
    <ISBN>978-XXXXXXXXXX</ISBN>
    <AUTHOR>Author Name</AUTHOR>
    <CATEGORY>Category</CATEGORY>
    <JACKETURL>filename.jpg</JACKETURL>
    <DESCRIPTION>Description text</DESCRIPTION>
  </BOOK>
</BOOKLIST>
```

## ?? Assignment Compliance

This implementation meets all requirements from the project specification:

- ? Login page with ownerID validation
- ? Admin page with complete functionality
- ? Database connection class (`myDatabaseConnection.cs`)
- ? Image upload capability
- ? XML parsing and database insertion
- ? GridView with image display
- ? Progress logging
- ? Error handling
- ? Database table management
- ? Clean, commented code

## ?? Known Limitations

- Single file upload at a time (not multiple file selection)
- No edit/delete functionality (future enhancement)
- Basic authentication (file-based, not secure for production)

## ?? Future Enhancements

- Multiple file upload support
- Edit existing book entries
- Delete books from inventory
- Search and filter functionality
- Customer-facing storefront
- Shopping cart integration
- User authentication with passwords

## ?? Support

For issues or questions:
1. Check `SETUP_INSTRUCTIONS.md` for detailed help
2. Review `QUICK_START.md` for quick answers
3. Verify all files are in correct locations
4. Ensure SQL Server LocalDB is installed

## ?? License

Educational project for ITWP 2300 coursework.

## ????? Author

Created for ITWP 2300 - Bob's Book Nook Project 1

---

**Ready to run!** Press F5 in Visual Studio and navigate to `/Login.aspx`