﻿namespace PullRequestQuantifier.Abstractions.Core
***REMOVED***
    using System.Collections.Generic;
    using PullRequestQuantifier.Abstractions.Git;

    public sealed class QuantifierInput
    ***REMOVED***
        /// <summary>
        /// Initializes a new instance of the <see cref="QuantifierInput"/> class.
        /// </summary>
        public QuantifierInput()
        ***REMOVED***
            Changes = new List<GitFilePatch>();
***REMOVED***

        /// <summary>
        /// Gets changed files containing info about the diff.
        /// </summary>
        public List<GitFilePatch> Changes ***REMOVED*** get; ***REMOVED***
***REMOVED***
***REMOVED***