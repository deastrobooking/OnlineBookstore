# Sample Book Cover Images

## For Testing the Sample XML

The `sample-books.xml` file in `App_Data/` references these image files:

1. **great-gatsby.jpg** - The Great Gatsby
2. **mockingbird.jpg** - To Kill a Mockingbird
3. **1984.jpg** - 1984
4. **pride-prejudice.jpg** - Pride and Prejudice
5. **catcher-rye.jpg** - The Catcher in the Rye

## How to Get Test Images

### Option 1: Download from Internet
Search for book cover images and download them with the correct filenames listed above.

### Option 2: Use Placeholder Images
1. Create simple placeholder images (any JPG)
2. Rename them to match the filenames above
3. Upload through the Admin interface

### Option 3: Create Your Own
Use any image editor to create simple 200x300px JPG files with the book titles written on them.

## Upload Instructions

1. Go to Admin page
2. Click "Browse" in the Upload Images section
3. Select one image file
4. Click "Load Images"
5. Repeat for each image

**Important**: Upload ALL images BEFORE uploading the XML file!

## Image Requirements

- **Format**: JPG, JPEG, PNG, or GIF
- **Size**: Any size (will be displayed at 100px height in GridView)
- **Naming**: Must match exactly what's in the XML `<JACKETURL>` tags
- **Location**: Will be stored in the `Img/` folder

## Testing Without Images

If you want to test without images:
1. Edit `sample-books.xml`
2. Use placeholder filenames like `placeholder.jpg`
3. Upload one placeholder image multiple times
4. Or modify the XML to remove image references (though GridView will show broken images)

## Troubleshooting

**Images not displaying?**
- Check that image files were uploaded successfully
- Verify filenames in XML match uploaded files exactly (case-sensitive)
- Look in the `Img/` folder to confirm files are there
- Check browser console for 404 errors on image paths

**Upload failing?**
- Check file size (default limit is 10MB per file)
- Ensure file format is supported (JPG/PNG/GIF)
- Verify `Img/` folder has write permissions
