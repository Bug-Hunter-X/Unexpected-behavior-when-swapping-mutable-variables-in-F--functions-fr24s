# F# Mutable Variable Swapping Bug

This example demonstrates a common issue in F# involving mutable variables and references.  The unexpected behavior arises when swapping mutable variables within and outside of functions.

The `bug.fs` file contains code that showcases this issue.  The `bugSolution.fs` file provides a corrected version, explaining how to properly handle mutable variables in this scenario.

## Issue:
The core problem lies in the way F# handles mutable variables passed to functions.  Simple assignment of mutable variables within a function does not change the external values, but modifying mutable reference values using `ref` does alter the external values.