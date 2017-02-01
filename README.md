# StatelessExampleByOrderStates
A simple example for dotnet-state-machine/stateless library.

# Main idea:
Initially order’s is in state “On-Air”.

Manager could “Approve” or “Reject” the order.
There are 2 kinds of manager: “Main” and “Regional”.
If “Regional” manager has approved the order – order become “Partially Approved”.
If “Main” manager has approved the order – order become “Approved”.

![alt tag](https://cloud.githubusercontent.com/assets/12991619/22498700/02ca1514-e86b-11e6-9e41-01fb8ade23f5.png)

