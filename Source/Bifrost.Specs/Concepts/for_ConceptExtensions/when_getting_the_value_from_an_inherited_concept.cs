﻿using Bifrost.Concepts;
using Machine.Specifications;

namespace Bifrost.Specs.Concepts.for_ConceptExtensions
{
    [Subject(typeof(ConceptExtensions))]
    public class when_getting_the_value_from_an_inherited_concept : given.concepts
    {
        static InheritingFromLongConcept value;
        static long primitive_value = 100;
        static object returned_value;

        Establish context = () =>
        {
            value = new InheritingFromLongConcept { Value = primitive_value };
        };

        Because of = () => returned_value = value.GetConceptValue();

        It should_get_the_value_of_the_primitive = () => returned_value.ShouldEqual(primitive_value);
    }
}