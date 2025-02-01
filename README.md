# Mapperly experiments

## Description

The purpose of this project is to experiment with
the [Mapperly](https://mapperly.riok.app/docs/getting-started/first-mapper/) NuGet package.

## Technologies Used

- **Programming Language**: C# 13.0
- **Framework**: .NET 9.0

## Requirements

Ensure you have the following installed on your system before running the project:

1. **.NET SDK 9.0** - [Download here](https://dotnet.microsoft.com/download/dotnet/9.0)
2. An IDE or editor with C# and .NET support, such as [JetBrains Rider](https://www.jetbrains.com/rider/)
   or [Visual Studio](https://visualstudio.microsoft.com/).

## Setup Instructions

Follow these steps to get the project running locally on your machine:

### Clone the Repository

``` bash
git clone <repository-url>
cd <project-directory>
```

## Running Locally

A **local setup** using the .NET SDK is recommended.

### 1. Install Dependencies

No manual dependency installation is needed; dependencies will be restored during the build.

### 2. Build the Project

```bash
dotnet build
```

### 3. Run the Project

```bash
dotnet run
```

### 4. Run Tests

To run tests locally, execute:

```bash
dotnet test
```

## Running the Project with Docker (Optional)

Docker is supported for building, running, and testing the project.

### Prerequisites

Make sure Docker are installed on your system:

- [Install Docker](https://docs.docker.com/get-docker/)

### Building and Running the Project with Docker

To build and run the main application, use the following command:

```bash
docker compose up --build firstmapper
```

This command restores dependencies, builds the app, and runs it inside a Docker container.

### Running Tests with Docker

To run tests inside a container, use the following command:

```bash
docker compose up --build firstmapper-tests
```

This command runs all tests defined in the project and outputs the results in the console.

---

## Testing Instructions Summary

- **Locally**: `dotnet test`
- **With Docker**: `docker compose up --build firstmapper-tests`

## Contributing

This is a **personal project**. Contributions are **not** required. Anyone interested in developing this project are
welcome to fork or clone for your own use.

## Credits

- [Michael Pritchard \(AKA Pen-y-Fan\)](https://github.com/pen-y-fan) original project

## License

MIT License (MIT). Please see [License File](LICENSE.md) for more information.
