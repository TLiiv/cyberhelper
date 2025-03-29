import React, { useState, ChangeEvent, FormEvent, useEffect } from "react";
import {
  Button,
  Input,
  Text,
  Box,
  Checkbox,
  Select,
  Portal,
  createListCollection,
} from "@chakra-ui/react";
import { Link, useSearchParams } from "react-router-dom";

interface ScamDonationPageProps {}

const ScamDonationPage: React.FC<ScamDonationPageProps> = () => {
  const [submitted, setSubmitted] = useState<boolean>(false);
  const [amount, setAmount] = useState<string>("");

  const [searchParams] = useSearchParams();

  const handleSubmit = (e: FormEvent) => {
    e.preventDefault();
    setSubmitted(true);
  };

  useEffect(() => {
    const amountParam = searchParams.get("amount");
    if (amountParam) {
      setAmount(amountParam);
    }
  }, [searchParams]);

  const makseviisid = createListCollection({
    items: [
      { label: "Pangaülekanne", value: "Pangaülekanne" },
      { label: "Krediitkaart", value: "Krediitkaart" },
      { label: "Paypal", value: "Paypal" },
    ],
  });

  return (
    <Box
      p={4}
      textAlign="center"
      width="100%"
      maxWidth="600px"
      margin="auto"
      alignItems="center"
      height="100vh"
    >
      <Box display="flex" flexDirection="column" alignItems="center">
        <Text mb={2} fontSize="xl" fontWeight="bold">
          Aitäh, et annetad Dharma Heategevusfondi {amount} Eurot!
        </Text>
        <Text fontSize="lg" fontWeight="semibold" mt={4} width="50%">
          Annetuse kinnitamiseks täida palun järgmised väljad:
        </Text>

        <Box mt={4} width="50%">
          <Text mb={2} fontSize="md" fontWeight="semibold">
            Eesnimi
          </Text>
          <Input placeholder="Sisesta oma eesnimi" />
        </Box>
        <Box mt={4} width="50%">
          <Text mb={2} fontSize="md" fontWeight="semibold">
            Perekonnanimi
          </Text>
          <Input placeholder="Sisesta oma perekonnanimi" />
        </Box>

        <Box mt={4} width="50%">
          <Text mb={2} fontSize="md" fontWeight="semibold">
            Email Address
          </Text>
          <Input type="email" placeholder="Sisesta oma email" />
        </Box>

        <Box mt={4} width="50%">
          <Text mb={2} fontSize="md" fontWeight="semibold">
            Telefoni number
          </Text>
          <Input placeholder="Sisesta oma telefoni number" />
        </Box>
      </Box>
      <Box display="flex" justifyContent="center" width="50%" mx="auto" mt={4}>
        <Select.Root collection={makseviisid} size="md" width="100%">
          <Select.HiddenSelect />
          <Select.Label fontWeight="semibold" fontSize="md">
            Vali makseviis
          </Select.Label>
          <Select.Control>
            <Select.Trigger>
              <Select.ValueText placeholder="Vali makseviis" />
            </Select.Trigger>
            <Select.IndicatorGroup>
              <Select.Indicator />
            </Select.IndicatorGroup>
          </Select.Control>
          <Portal>
            <Select.Positioner>
              <Select.Content>
                {makseviisid.items.map((method) => (
                  <Select.Item item={method} key={method.value}>
                    {method.label}
                    <Select.ItemIndicator />
                  </Select.Item>
                ))}
              </Select.Content>
            </Select.Positioner>
          </Portal>
        </Select.Root>
      </Box>

      <Box mt={4}>
        <Checkbox.Root>
          <Checkbox.HiddenInput />
          <Checkbox.Control />
          <Checkbox.Label>Olen tingimustega nõus</Checkbox.Label>
        </Checkbox.Root>
      </Box>

      <Box mt={6}>
        <Button width="30%" onSubmit={handleSubmit} disabled as={Link}>
          Anneta {amount} Eurot
        </Button>
      </Box>

      {submitted && (
        <Text mt={6} color="green.500">
          Your donation is being processed! Please check your email for
          confirmation.
        </Text>
      )}
    </Box>
  );
};

export default ScamDonationPage;
