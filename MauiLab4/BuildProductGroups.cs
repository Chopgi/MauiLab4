using System;
using System.Collections.Generic;
using System.Text;

namespace MauiLab4
{
    public class BuildProductGroups
    {
        public List<ProductGroup> ProductList { get; set; } = new List<ProductGroup>();


        public BuildProductGroups()
        {
            ProductList.Add(new ProductGroup("Tacos", new List<Product>
            {
                new Product
                {
                    Name = "Taco 1",
                    Description = "This is a description for Taco 1",
                    Price = "$1.99",
                    ImageUrl ="fish_taco.png"
                },
                new Product
                {
                    Name = "Taco 2",
                    Description = "This is a description for Taco 1",
                    Price = "$1.99",
                    ImageUrl ="birria_taco.png"
                },
                new Product
                {
                    Name = "Taco 3",
                    Description = "This is a description for Taco 1",
                    Price = "$1.99",
                    ImageUrl ="american_tacos.png"
                }
            }));

            ProductList.Add(new ProductGroup("Hotdogs", new List<Product>
            {
                new Product
                {
                    Name = "Hotdog 1",
                    Description = "This is a description for Hotdog 1",
                    Price = "$1.99",
                    ImageUrl ="plain_hot_dog.png"
                },
                new Product
                {
                    Name = "Hotdog 2",
                    Description = "This is a description for Hotdog 2",
                    Price = "$1.99",
                    ImageUrl ="chili_hot_dog.png"
                },
                new Product
                {
                    Name = "Hotdog 3",
                    Description = "This is a description for Hotdog 3",
                    Price = "$1.99",
                    ImageUrl ="veggie_hot_dog.png"
                }
            }));

           ProductList.Add(new ProductGroup("Hamburgers", new List<Product>
            {
                new Product
                {
                    Name = "Hamburger 1",
                    Description = "This is a description for Hamburger 1",
                    Price = "$1.99",
                    ImageUrl ="plain_burger.png"
                },
                new Product
                {
                    Name = "Hamburger 2",
                    Description = "This is a description for Hamburger 2",
                    Price = "$1.99",
                    ImageUrl ="big_mac_burger.png"
                },
                new Product
                {
                    Name = "Hamburger 3",
                    Description = "This is a description for Hamburger 3",
                    Price = "$1.99",
                    ImageUrl ="char_burger.png"
                }
            }));


        }


    }
}
