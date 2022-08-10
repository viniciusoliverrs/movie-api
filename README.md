#Movie API

## Swagger

[Click here](https://api-fake-movies.herokuapp.com/swagger/index.html)


## Deploy
To deploy on heroku you need docker and heroku cli.

```bash
  docker build -t movie-api . 
  docker-compose build
  heroku login
  heroku container:login
  heroku container:push web -a [app name on heroku]
  heroku container:release web [app name on heroku]
```


## Author

- [@viniciusoliverrs](https://www.linkedin.com/in/viniciusoliverrs/)

