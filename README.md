# Cognitive Complexity Coding Katas - With Code Examples From Stackoverflow

This repository contains a collection of coding katas based on code examples from Stackoverflow questions where people from the community ask for getting help with reducing cognitive complexity of their code.

# Goal

Get the code under test with 100% code coverage and try to reduce the cognitive complexity as good as possible while making tests pass all the time.
Try to use automated refactorings from your IDE as extensively as possible :-) 

# Background Information on Cognitive Complexity

As opposed to ***Cyclomatic*** Complexity ***Cognitive*** Complexity rather focuses on taking account the complexity perceived by the human brain. This is why it does not simply indicate the number of conditional paths (simplified the number of conditionals plus 1 for the return statement) as done for the cyclomatic complexity calculation.

The cognitive complexity metric also considers nested conditions (e.g. an if inside an if, inside an if statement) which makes it even harder to read and understand the code from a human's perspective.

The following sample from the SonarQube documentation (https://www.sonarsource.com/docs/CognitiveComplexity.pdf) outlines the concept:

```java
if (someVariableX > 3) { // +1
    if (someVariableY < 3) { // +2, nesting = 1
        if (someVariableZ === 8) { // +3, nesting = 2
            someResult = someVariableX + someVariableY - someVariableZ;
        }
    }
}
```

It also needs to be considered that binary operations add to the complexity but nested conditions even add a score of plus 1 for each nested condition.

In the sample shown above the *cognitive complexity* would be **6**, while the *cyclomatic complexity* would only be **4** (one for each conditional and one for the return path);

More explanations and sample calculations for cognitive complexity can be found here:
- https://www.sonarsource.com/docs/CognitiveComplexity.pdf
- https://stackoverflow.com/a/62867219/7730554
- https://stackoverflow.com/a/70537264/7730554

# Code Sample References

## SampleA

Based on https://stackoverflow.com/q/50562057/7730554
