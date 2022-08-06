<html>
<body>
  <p><b>This project aim</b> is how to do our code more optimum about cohesion and coupling. Firstly we created a problem. You can see this in the "Problem created" commit. We have an elevator, 5 floor and some passengers. We want to manage and test the elevator movement. We have to check door status, elevator's weight and floor count.</p>

<p>If you check over my "Problem created" commit, you will see the data-driven approach. Elevator class had some unnecessary fields. Elevator class does not need the Floor information. So I created a Floor Enum. Also ElevatorDataTest class does not do anything about movement. It is not test class job. So we need the a ResponsibleElevator class for movement things and passengers management. Although we need still a test class for test our code.</p>

<p><b>The cohesion and coupling</b> of Elevator, which is the obtained with a responsibility-driven approach, is more optimum. So clients are simplified. Dependencies are kept to a minimum. This makes code maintenance easier.</p>

<p>The reason for the existence of objects is their behaivor. Data is where behaivor is there. Encapsulation combines behaivor and data to fulfill responsibilities.</p>

<p>Data exchange should be minimal as in this solution. Getter-setter approach or data-driven approach increase the data exchange.</p>
</body>
</html>
