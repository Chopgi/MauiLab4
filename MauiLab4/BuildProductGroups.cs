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
                    Name = "Fish Tacos",
                    Description = "Made with fish.",
                    Price = "$1.99",
                    imageSource ="fish_taco.png"
                },
                new Product
                {
                    Name = "Birria Tacos",
                    Description = "Tacos made with birria.",
                    Price = "$2.99",
                    imageSource ="birria_taco.png"
                },
                new Product
                {
                    Name = "American Tacos",
                    Description = "Made with a hard shell.",
                    Price = "$0.99",
                    imageSource ="american_tacos.png"
                }
            }));

            ProductList.Add(new ProductGroup("Hotdogs", new List<Product>
            {
                new Product
                {
                    Name = "Hotdog",
                    Description = "Classic Hot Dog.",
                    Price = "$1.45",
                    imageSource ="plain_hot_dog.png"
                },
                new Product
                {
                    Name = "Chili Dog",
                    Description = "Chili Dog, made with chili and onion.",
                    Price = "$2.99",
                    imageSource ="chili_dog.png"
                },
                new Product
                {
                    Name = "Veggie Dog",
                    Description = "Hot dog with guacamole.",
                    Price = "$1.99",
                    imageSource ="veggie_hot_dog.png"
                }
            }));

           ProductList.Add(new ProductGroup("Hamburgers", new List<Product>
            {
                new Product
                {
                    Name = "Hamburger",
                    Description = "Basic hamburger.",
                    Price = "$2.45",
                    imageSource ="plain_burger.png"
                },
                new Product
                {
                    Name = "Bic Mac style Burger",
                    Description = "Just like the Big Mac, but with a homemade taste.",
                    Price = "$3.00",
                    imageSource ="big_mac_burger.png"
                },
                new Product
                {
                    Name = "Char Burger",
                    Description = "Toasted for taste.",
                    Price = "$3.50",
                    imageSource ="char_burger.png"
                }
            }));


        }


    }
}
