# ?? Quick Start Guide - Bob's Book Nook

## Run the Application

1. Open in Visual Studio (or compatible IDE)
2. Press **F5** to run
3. Navigate to **Login.aspx**

## Quick Test Flow

### Step 1: Login
- **URL**: `/Login.aspx`
- **Owner ID**: `test`
- **Re-enter**: `test`
- **Result**: Redirects to Admin page

### Step 2: Upload Images
1. Click **Browse** (Upload Images section)
2. Select a `.jpg` image
3. Click **Load Images**
4. Repeat for more images

### Step 3: Upload XML
1. Click **Browse** (Upload XML section)
2. Select `App_Data/sample-books.xml`
3. Click **Load XML**
4. Watch progress log

### Step 4: View Books
1. Click **View Inventory**
2. See GridView with books and images

## File Locations

| File | Location | Purpose |
|------|----------|---------|
| Login page | `Login.aspx` | User authentication |
| Admin page | `Admin.aspx` | Book management |
| Database class | `App_Code/myDatabaseConnection.cs` | DB operations |
| Sample data | `App_Data/sample-books.xml` | Test XML |
| Images | `Img/` | Book covers |
| Config | `Web.config` | App settings |

## Common Tasks

### Reset Everything
1. Click **Clear Database**
2. Click **Reset User**
3. Login again

### Add New Books
1. Upload book cover images
2. Create XML with book data
3. Upload XML file
4. View inventory

### Change User
1. Click **Reset User**
2. Enter new Owner ID
3. Start fresh with new database table

## URLs

- Login: `http://localhost:[port]/Login.aspx`
- Admin: `http://localhost:[port]/Admin.aspx`

## Database Table Name Format

`{ownerID}_BOOKS`

Example: `test_BOOKS`, `admin_BOOKS`

## XML Field Mapping

| XML Tag | Database Column | Notes |
|---------|----------------|-------|
| `<TITLE>` | Title | Max 64 chars |
| `<ISBN>` | ISBN | Max 14 chars, unique |
| `<AUTHOR>` | Author | Max 64 chars |
| `<CATEGORY>` | Category | Max 48 chars |
| `<JACKETURL>` | Image | Filename only |
| `<DESCRIPTION>` | Description | Max 255 chars |

## Tips

? **Do This:**
- Upload images BEFORE XML
- Use consistent image filenames
- Test with sample data first
- Check progress log for errors

? **Avoid:**
- Uploading XML before images
- Using special characters in filenames
- Exceeding field length limits
- Forgetting to view inventory after upload

## Troubleshooting

| Problem | Solution |
|---------|----------|
| Can't login | Check App_Data folder permissions |
| Images don't display | Upload images first, check filenames |
| XML fails | Check XML format matches sample |
| Database error | Click "Clear Database" and retry |

## Next Steps

1. ? Complete this project
2. ?? Add more features (edit, delete books)
3. ?? Customize styling
4. ?? Add more authentication
5. ?? Add search and filter

---

**Need Help?** Check `SETUP_INSTRUCTIONS.md` for detailed information.
