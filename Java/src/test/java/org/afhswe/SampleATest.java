package org.afhswe;

import org.junit.Test;
import static org.assertj.core.api.Assertions.*;

public class SampleATest
{
    @Test
    public void noFieldSeparatorFound()
    {
        var sut = new SampleA();
        assertThat(sut.findDelimiter("")).isEqualTo('\0');
    }

    @Test
    public void findsFirstCharacter_forDefaultCase()
    {
        var sut = new SampleA();
        assertThat(sut.findDelimiter("Some word")).isEqualTo('S');
    }

    @Test
    public void findsTabFieldSeparator()
    {
        var sut = new SampleA();
        assertThat(sut.findDelimiter("\\t")).isEqualTo('\t');
    }

    @Test
    public void findsUnicodeSeparator()
    {
        var sut = new SampleA();
        assertThat(sut.findDelimiter("0")).isEqualTo('\0');
    }
}
