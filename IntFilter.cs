       [TestMethod]
        public async Task {repo_name}_IntFilter_ReturnValid()
        {
            {repo_name}Filter filter = new {repo_name}Filter
            {
                {field_name} = new IntFilter() { Equal = /** data over there */ }
            };

            var result = await repository.Count(filter);
            var expected = await DbContext.{repo_name}.Where(b => b.DiscountPeriod == 3).Select(b => b.Id).CountAsync();
            Assert.AreEqual(expected, result);
        }
        
        