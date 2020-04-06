# .Net Core ToDo Web API

1. Created .Net Core web API named "ToDoAPI". API make use of in-memory storage to store list of todos
2. API does all CRUD operations using HttpGet, HttpPost, HttpPut, HttpDelete
3. Implemented Swagger for API documentation
4. Containerized API "todoapi" to Linux environment and uploaded image to Docker Hub.
5. To test the docker image open any Linux terminal with Docker installed on it.
6. Run command "sudo docker --version" to confirm if docker is installed (Need Docker Hub credentials)
7. Then run the image by typing the command - "sudo docker run -p 8080:80 vishnukumarv/todoapi"
8. API can be accessed and tested using SwaggerUI, which cane be accessed using URL - http://localhost:8080/swagger/index.html
9. Then open a browser and access the API by calling http://localhost:8080/todo
