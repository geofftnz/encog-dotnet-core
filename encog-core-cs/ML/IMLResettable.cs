//
// Encog(tm) Core v3.1 - .Net Version
// http://www.heatonresearch.com/encog/
//
// Copyright 2008-2012 Heaton Research, Inc.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//  http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//   
// For more information on Heaton Research copyrights, licenses 
// and trademarks visit:
// http://www.heatonresearch.com/copyright
//
namespace Encog.ML
{
    /// <summary>
    /// Defines a Machine Learning Method that can be reset to an untrained 
    /// starting point.  Most weight based machine learning methods, such
    /// as neural networks support this.  Support vector machines do not.
    /// </summary>
    ///
    public interface IMLResettable : IMLMethod
    {
        /// <summary>
        /// Reset the weights.
        /// </summary>
        ///
        void Reset();

        /// <summary>
        /// Reset the weights with a seed.
        /// </summary>
        ///
        /// <param name="seed">The seed value.</param>
        void Reset(int seed);
    }
}
