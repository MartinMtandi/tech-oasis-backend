using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace tech_oasis_backend.Model
{
    public class SeedData
    {

        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new ProfileContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<ProfileContext>>()))
            {
                // Look for any movies.
                if (context.Profiles.Any())
                {
                    return;   // DB has been seeded
                }

                context.Profiles.AddRange(
                    new Profile
                    {
                        Id = 1,
                        Firstname = "Bill",
                        Lastname = "Gates",
                        Bio = "Bill Gates, the co-founder and mastermind behind Microsoft (MSFT), is well known for his giving nature through the Bill & Melinda Gates Foundation, but he was less than giving in business.",
                        WebsiteURL = "www.microsoft.com",
                        Email = "bill@microsoft.com",
                        Phone = "+34 891 901 9224",
                        ProfileIMG = "Bill-Gates.jpg"
                    },
                   new Profile {
                        Id = 2,
                        Firstname = "Jeff",
                        Lastname = "Bezos",
                        Bio = "In 1994, Jeff Bezos launched Amazon.com Inc. (AMZN) after leaving a well-paying job at a Wall Street hedge fund. By starting Amazon as a simple online bookseller, Bezos was hoping to cash in on the rapid growth of Internet businesses in the 90s.",
                        WebsiteURL= "www.amazon.com",
                        Email = "jeff@amazon.com",
                        Phone = "+44 542 233 1234",
                        ProfileIMG = "Jeff_Bezos.jpg"
                   },
                   new Profile
                   {
                        Id = 3,
                        Firstname = "Larry",
                        Lastname = "Ellison",
                        Bio = "Oracle Corp. (ORCL) founder Larry Ellison is well known for his rags-to-riches story. He went from college dropout to self-taught programmer to billionaire, and through Oracle's success, he has become the third richest person in the world.",
                        WebsiteURL = "www.oracle.com",
                        Email = "bill@microsoft.com",
                        Phone = "+88 893 341 3941",
                        ProfileIMG = "Larry_Ellison.jpg"
                   },
                   new Profile
                   {
                        Id = 4,
                        Firstname = "Mark",
                        Lastname = "Zuckerberg",
                        Bio = "Facebook, Inc. (FB) founder Mark Zuckerberg dropped out of Harvard to launch a business that has changed the social media landscape on a massive scale. Along the way, he lost a few friends (as told in “The Social Network”.",
                        WebsiteURL = "www.facebook.com",
                        Email = "mark@facebook.com",
                        Phone = "+88 546 341 3131",
                        ProfileIMG = "Mark_Zurkerburg.jpg"
                   },
                   new Profile
                   {
                        Id= 5,
                        Firstname = "Steve",
                        Lastname = "Ballmer",
                        Bio = "Steve Ballmer is the former CEO of Microsoft, running the tech company from 2000 to 2014. He took over Microsoft following the dotcom bubble, having started out at Microsoft in 1980 after dropping out of Stanford’s MBA program.",
                        WebsiteURL = "www.nba.com",
                        Email = "steve@nba.com",
                        Phone = "+55 546 901 7121",
                        ProfileIMG = "Steve_Ballmer.png"
                   },
                   new Profile
                   {
                        Id = 6,
                        Firstname = "Larry",
                        Lastname = "Page",
                        Bio = "Larry Page is the other co-founders of Google Inc. (GOOG). The company’s PageRank algorithm for generating search results, named after Page, helped propel Google from a research project to a public corporation in just five years.",
                        WebsiteURL = "www.google.com",
                        Email = "larry@google.com",
                        Phone = "+63 500 901 2190",
                        ProfileIMG = "Larry_Page.jpg"
                   }

                );
                context.SaveChanges();
            }
        }
    }
}
