## Configure Environment Variables

Before the tests are run, please set the environment variables LT_USERNAME & LT_ACCESS_KEY from the terminal. The account details are available on your [LambdaTest Profile](https://accounts.lambdatest.com/detail/profile) page.

For macOS:

```bash
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
```

For Linux:

```bash
export LT_USERNAME=LT_USERNAME
export LT_ACCESS_KEY=LT_ACCESS_KEY
```

For Windows:

```bash
set LT_USERNAME=LT_USERNAME
set LT_ACCESS_KEY=LT_ACCESS_KEY
```

Please visit [LambdaTest Capabilities Generator](https://www.lambdatest.com/capabilities-generator/) in order to generate capabilities for the test cases.

## How to run tests

Once the environment variables are exported, run the following command from the terminal (after navigating to the root directory):

```bash
dotnet test LTSpecFlow.sln
```

Shown below is the test execution on terminal and LambdaTest:

<img width="1422" alt="Screenshot 2022-08-03 at 6 14 03 PM" src="https://user-images.githubusercontent.com/87163413/182611279-3dd696be-fb72-47ce-b3ad-0873124e8e02.png">

<img width="1430" alt="Screenshot 2022-08-03 at 6 14 47 PM" src="https://user-images.githubusercontent.com/87163413/182611260-91579400-1bbc-4610-a301-befd6f853f92.png">

