## ASP.NET REST API
Project implements RESTful CRUD web API in C# using ASP.NET for managing a banner model. Data is backed by **MongoDB**. Method providing the HTML stored in the banner is also implemented.

### Packages
* **Controllers**
  
  [BannerController](BannerFlow/Controllers/BannerController.cs)
* **Services**

  [IBannerService](BannerFlow/Services/IBannerService.cs)
  
  [BannerService](BannerFlow/Services/BannerService.cs)
* **Repositories**

  [IBannerRepository](BannerFlow/Repositories/IBannerRepository.cs)
  
  [BannerRepository](BannerFlow/Repositories/BannerRepository.cs)
* **Models**

  [Banner](BannerFlow/Models/Banner.cs)
* **DataTransferObjects**
  
  [BannerDTO](BannerFlow/DataTransferObjects/BannerDTO.cs)
* **Validators**

  [HtmlValidator](BannerFlow/Validators/HtmlValidator.cs)

### API Calls
* **GET api/banners**

  Returns all banners from the database.
* **GET api/banners/{id}**

  Returns the banner from the database for a specified ID.
* **POST api/banners**

  Creates a banner record in the database.
* **PUT api/banners/{id}**

  Updates the banner record in the database for a specified ID with sent update data.
* **DELETE api/banners/{id}**

  Removes the banner record from the database for a specified ID.
* **GET api/banners/{id}/html**

  Provides the HTML stored in the banner. Renders correctly in a modern browser - HTML load available in the [developed client](BannerFlow/Index.html).

### Testing the API
Testing was done using both: 
* [Postman](Postman%20API%20testing)

  Used for testing all of the API calls. Provides a better insight to illegal calls and for observing error handling.
* [Developed client](BannerFlow/Index.html)

  Also used for testing of the API calls but with focus on proper loading of HTML into the modern web browser.
